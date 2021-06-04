using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SP.Data.Models
{
    class RS_catalog_ai
    {
		public string Rs_catalog_uuid { get; set; }
		public string Catalog_name { get; set; }
		public string Parent_uuid { get; set; }
		public bool Enabled_flag { get; set; }
		public DateTime Start_date_active { get; set; }
		public DateTime End_date_active { get; set; }
		public string Created_by { get; set; }
		public DateTime Creation_date { get; set; }
		public string Last_updated_by { get; set; }
		public DateTime Last_update_date { get; set; }
		public bool Is_deleted { get; set; }
		List<RS_repository_ai> Repository { get; set; }
    }
}
