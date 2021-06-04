using Newtonsoft.Json;
using Npgsql;
using SP.Data.Methods;
using SP.Data.Mock;
using SP.Data.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SP
{
    public partial class Form1 : Form
    {

        private string dict_code = "";
        private string sql_str = "";
        private string dict_name = "";
        private string hier_sql = "";
        private bool is_hier = false;

        public Form1()
        {
            InitializeComponent();
            treeView1.Nodes.Clear();
            CopyTree(GetTreeViewCatalogs.Catalogs(), treeView1);
            treeView1.Sort();
        }


        public void CopyNode(TreeNode node, TreeNodeCollection dest)
        {
            TreeNode copy = new TreeNode(node.Name);
            copy.Text = node.Text;
            copy.Name = node.Name;
            copy.ImageKey = node.ImageKey;
            copy.ImageIndex = node.ImageIndex;
            dest.Add(copy);
            foreach (TreeNode child in node.Nodes)
            {
                CopyNode(child, copy.Nodes);


            }
        }

        public void CopyTree(TreeView src, TreeView dest)
        {
            foreach (TreeNode node in src.Nodes)
            {
                CopyNode(node, dest.Nodes);
            }
        }
        

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //Реализовать поиск
        }

        private void treeView1_DoubleClick(object sender, EventArgs e)
        {
            if (treeView1.SelectedNode.ImageIndex != 0)
            {
                MockRS_repository_ai report = new MockRS_repository_ai();
                RS_repository_ai edit_report = report.GetReport(treeView1.SelectedNode.Name);
                textBox2.Text = edit_report.Report_setting_name;
                checkBox1.Checked = edit_report.Enabled_flag;
                //json_text.Text = Encoding.UTF8.GetString(edit_report.Report_setting_structure);
                Root tmp = JsonConvert.DeserializeObject<Root>(Encoding.UTF8.GetString(edit_report.Report_setting_structure));
                dataGridView1.Rows.Clear();
                int i = 1;
                foreach (var SheetSettingList in tmp.SheetSettingList)
                {
                    dataGridView1.Rows.Add($"Раздел {i}");
                    foreach (var FilterList in SheetSettingList.FilterList)
                    {
                        string o = "";
                        foreach (var pf in FilterList.ParentFilterIndexList)
                        {
                            o += pf.ToString();
                        }
                        //json_text.Text += $"{FilterList.DictionaryCode}\t{FilterList.AtrName}\r\n";
                        dataGridView1.Rows.Add(FilterList.AtrName, FilterList.DictionaryCode, FilterList.DataType, FilterList.FormItemSetting.IsHierarchyList, o);
                    }
                    i++;
                }

            }
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //Вытаскиваем sql выражение
            richTextBox1.Clear();
            string z = "";
            bool hier = false;
            foreach (DataGridViewRow p in dataGridView1.SelectedRows)
            {
                z = p.Cells[1].Value.ToString();
                hier = (bool)p.Cells[3].Value;
                dict_name = $"{p.Cells[0].Value.ToString()}. {textBox2.Text}";
            }
            dict_code = z;
            is_hier = hier;
            NpgsqlDataReader result = null;
            if (hier == false)
            {
                result = ExecuteSql.selectSql($"select sql_str from ai.dict_descr_ai where dictionary_code = '{z}'");
            }
            else
            {
                result = ExecuteSql.selectSql($"select hier_sql_str as sql_str from ai.dict_descr_ai where dictionary_code = '{z}'");
            }
            if (result.HasRows)
            {
                foreach (DbDataRecord p in result)
                {
                    richTextBox1.Text += p["sql_str"].ToString();
                    string mystring = @":l_report_date_from";
                    if (richTextBox1.Find(mystring) > 0)
                        {
                            int my1stPosition = richTextBox1.Find(mystring);
                            richTextBox1.SelectionStart = my1stPosition;
                            richTextBox1.SelectionLength = mystring.Length;
                            richTextBox1.SelectionColor = Color.Blue;
                        }
                    mystring = @":l_parentFilterIndex";
                    if (richTextBox1.Find(mystring) > 0)
                    {
                        int my1stPosition = richTextBox1.Find(mystring);
                        richTextBox1.SelectionStart = my1stPosition;
                        richTextBox1.SelectionLength = mystring.Length+1;
                        richTextBox1.SelectionColor = Color.Red;
                    }
                    //richTextBox1.Rtf.
                }
            }
            hier_sql = is_hier ? richTextBox1.Text : null;
            sql_str = is_hier ? null : richTextBox1.Text;

            richTextBox2.Clear();
            //Запрос в таблицу report_filters
            NpgsqlDataReader result2 = ExecuteSql.selectSql($"select new_sql_str, new_dict_code from dw.report_filters where dict_code = '{z}' limit 1");
            if (result2.HasRows) {
                foreach (DbDataRecord p in result2)
                {
                    richTextBox2.Text += "--"+p["new_dict_code"].ToString();
                    richTextBox2.Text += "\r\n" + p["new_sql_str"].ToString();
                }
            }
            if (richTextBox1.Text == richTextBox2.Text)
            {
                label6.Text = "Соответствует report_filters";
                label6.ForeColor = Color.Green;
            }
            else
            {
                label6.Text = "Не соответствует report_filters";
                label6.ForeColor = Color.Red;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Генерится запрос на инсерт или апдейт
            sql_str = is_hier ? null : richTextBox1.Text;
            hier_sql = is_hier ? richTextBox1.Text : null;
            richTextBox1.Text = GenDictUpdate.UpdateDict(dict_code, sql_str, dict_name, hier_sql, is_hier);

        }
    }
}
