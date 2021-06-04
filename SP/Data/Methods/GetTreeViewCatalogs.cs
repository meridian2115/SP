using SP.Data.Mock;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SP.Data.Methods
{
    class GetTreeViewCatalogs
    {
        public static TreeView Catalogs() {
            TreeView treeView1 = new TreeView();
            MockRS_catalog_ai catalogs = new MockRS_catalog_ai();
            foreach (var p in catalogs.Allcatalog_ai)
            {
                if (p.Parent_uuid == "")
                {
                    treeView1.Nodes.Add(p.Rs_catalog_uuid, p.Catalog_name, 0);
                }
            }
            foreach (var p in catalogs.Allcatalog_ai)
            {
                if (p.Parent_uuid != "")
                {
                    TreeNode[] findTreeNodes = treeView1.Nodes.Find(p.Parent_uuid, true);
                    if (findTreeNodes != null)
                    {
                        foreach (var s in findTreeNodes)
                        {
                            switch (s.Level)
                            {
                                case 0:
                                    treeView1.Nodes[s.Index].Nodes.Add(p.Rs_catalog_uuid, p.Catalog_name, 0);
                                    break;
                                case 1:
                                    treeView1.Nodes[s.Parent.Index].Nodes[s.Index].Nodes.Add(p.Rs_catalog_uuid, p.Catalog_name, 0);
                                    break;
                                default:
                                    Console.WriteLine("Default case");
                                    break;
                            }
                        }
                    }
                }
            }
            MockRS_repository_ai reports = new MockRS_repository_ai();
            foreach (var p in reports.Allrepository_ai)
            {
                TreeNode[] findTreeNodes = treeView1.Nodes.Find(p.RS_catalog_uuid, true);
                foreach (var s in findTreeNodes)
                {
                    switch (s.Level)
                    {
                        case 0:
                            treeView1.Nodes[s.Index].Nodes.Add(p.RS_repository_uuid, p.Report_setting_name, 1);
                            break;
                        case 1:
                            treeView1.Nodes[s.Parent.Index].Nodes[s.Index].Nodes.Add(p.RS_repository_uuid, p.Report_setting_name, 1);
                            break;
                        case 2:
                            treeView1.Nodes[s.Parent.Parent.Index].Nodes[s.Parent.Index].Nodes[s.Index].Nodes.Add(p.RS_repository_uuid, p.Report_setting_name, 1);
                            break;
                        default:
                            Console.WriteLine("Default case");
                            break;
                    }
                }
            }
            return treeView1;
        }
    }
}
