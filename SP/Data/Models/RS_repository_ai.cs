using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SP.Data.Models
{
    class RS_repository_ai
    {
        public string RS_repository_uuid { get; set; }
        public string RS_catalog_uuid { get; set; }
        public string Report_setting_name { get; set; }
        public byte[] Report_setting_structure { get; set; }
        public bool Enabled_flag { get; set; }
        public DateTime Start_date_active { get; set; }
        public DateTime End_date_active { get; set; }
        public string Created_by { get; set; }
        public DateTime Creation_date { get; set; }
        public DateTime Last_updated_by { get; set; }
        public DateTime Last_update_date { get; set; }
        public bool Is_deleted { get; set; }
        RS_catalog_ai Catalog { get; set; }
    }
}
