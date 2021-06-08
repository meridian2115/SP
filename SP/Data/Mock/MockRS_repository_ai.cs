using Npgsql;
using SP.Data.Interfaces;
using SP.Data.Methods;
using SP.Data.Models;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SP.Data.Mock
{
    class MockRS_repository_ai : IRS_repository_ai
    {
        public IEnumerable<RS_repository_ai> Allrepository_ai {
            get {
                NpgsqlDataReader result = ExecuteSql.selectSql("select rs_repository_uuid, rs_catalog_uuid, report_setting_name from ai.rs_repository_ai where is_deleted = false order by rs_catalog_uuid");
                List<RS_repository_ai> list = new List<RS_repository_ai>();
                if (result.HasRows)
                {
                    foreach (DbDataRecord p in result)
                    {

                        list.Add(item: new RS_repository_ai { RS_repository_uuid = p["rs_repository_uuid"].ToString(), RS_catalog_uuid = p["rs_catalog_uuid"].ToString(), Report_setting_name = p["report_setting_name"].ToString() });
                    }
                }
                return list;
            }
        }

        public RS_repository_ai GetReport(string uuid) {
            RS_repository_ai report = new RS_repository_ai();
            NpgsqlDataReader result = ExecuteSql.selectSql($"select rs_repository_uuid, rs_catalog_uuid, report_setting_name, report_setting_structure, enabled_flag, start_date_active, end_date_active, created_by, creation_date, last_updated_by, last_update_date, is_deleted from ai.rs_repository_ai where rs_repository_uuid = '{uuid}'");
            try
            {
                if (result.HasRows)
                {
                    foreach (DbDataRecord p in result)
                    {
                        report.RS_repository_uuid = p["rs_repository_uuid"].ToString();
                        report.RS_catalog_uuid = p["rs_catalog_uuid"].ToString();
                        report.Report_setting_name = p["report_setting_name"].ToString();
                        report.Report_setting_structure = (byte[])p["report_setting_structure"];
                        report.Enabled_flag = (bool)p["enabled_flag"];
                        //report.Start_date_active = (DateTime)p["start_date_active"];
                        //report.End_date_active = (p["end_date_active"].ToString() != "") ? (DateTime)p["end_date_active"] : DateTime.Now;
                        report.Created_by = p["created_by"].ToString();
                        //report.Creation_date = (DateTime)p["creation_date"];
                        //report.Last_updated_by = (DateTime)p["last_updated_by"];
                        //report.Last_update_date = (DateTime)p["last_update_date"];
                        report.Is_deleted = (bool)p["is_deleted"];
                    }
                }
            }
            catch (Exception)
            {
                //Иногда БД не отвечает
            }
            return report;
        }
    }
}
