using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SP.Data.Methods
{
    class GenDictUpdate
    {
        public static string UpdateDict(string dict_code, string sql_str, string dict_name, string hier_sql, bool is_hier) {
            sql_str = sql_str != null ? sql_str.Replace("'", "''") : null;
            hier_sql = hier_sql != null ? hier_sql.Replace("'", "''") : null;
            string result = "do $$\r\n" +
                "DECLARE\r\n" +
                "\tg_pkg varchar = 'ai'; --current_schema;\r\n" +
                "\tl_data_type varchar;\r\n" +
                "\tl_exec boolean = false;\r\n" +
                "\tl_bas_ai ai.bas_ai % rowtype;\r\n" +
                "BEGIN\r\n" +
                "\tselect * from ai.bas_ai into l_bas_ai where is_actual = 1;\r\n" +
                $"\tif not exists (select 1 from ai.dict_descr_ai where upper(dictionary_code)=upper('{dict_code}'))\r\n" +
                $"\tthen\r\n";
            result += !is_hier ? $"\tinsert into ai.dict_descr_ai(dictionary_code,sql_str,dictionary_name,ba_id,ba_uuid,is_hierarchy)\r\n" 
                : $"\tinsert into ai.dict_descr_ai(dictionary_code,hier_sql_str,dictionary_name,ba_id,ba_uuid,is_hierarchy)\r\n";
            result += $"\tvalues\r\n" +
                $"\t\t('{dict_code}',\r\n";
            result += !is_hier ? $"\t\t'{sql_str}', \r\n" : $"\t\t'{hier_sql}'\r\n";
            result += $"\t\t'{dict_name}', \r\n" +
                $"\t\tl_bas_ai.ba_id, \r\n" +
                $"\t\tl_bas_ai.ba_uuid, \r\n" +
                $"\t\t{is_hier} \r\n" +
                $");\r\n" +
                $"else\r\n" + // 123
                $"\tupdate ai.dict_descr_ai\r\n" +
                $"\tset\r\n";
            result += !is_hier ? $"\t\tsql_str ='{sql_str}',\r\n" : $"\t\thier_sql_str = '{hier_sql}',\r\n";
            result += $"\t\tis_hierarchy = {is_hier}\r\n" +
                $"\twhere upper(dictionary_code)=upper('{dict_code}');\r\n" +
                $"end if;\r\n" +
                $"end$$;";
            return result;
        }
    }
}
