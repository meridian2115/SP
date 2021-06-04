using SP.Data.Interfaces;
using SP.Data.Models;
using SP.Data.Methods;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;
using System.Data.Common;

namespace SP.Data.Mock
{
    class MockRS_catalog_ai : IRS_catalog_ai
    {
        public IEnumerable<RS_catalog_ai> Allcatalog_ai
        {
            get
            {
                NpgsqlDataReader result = ExecuteSql.selectSql("select rs_catalog_uuid, catalog_name, parent_uuid from ai.rs_catalog_ai where is_deleted = false order by catalog_name");
                List<RS_catalog_ai> list = new List<RS_catalog_ai>();
                if (result.HasRows)
                {
                    foreach (DbDataRecord p in result)
                    {
                        
                        list.Add(item: new RS_catalog_ai { Catalog_name = p["catalog_name"].ToString(), Rs_catalog_uuid = p["rs_catalog_uuid"].ToString(), Parent_uuid = p["parent_uuid"].ToString() });
                    }
                }
                return list;
            }
        }
    }
}
