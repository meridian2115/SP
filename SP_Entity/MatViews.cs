using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class MatViews
    {
        public MatViews()
        {
            ReportFilters = new HashSet<ReportFilters>();
        }

        public int Id { get; set; }
        public string ViewName { get; set; }
        public string ViewSql { get; set; }
        public string ViewRefresh { get; set; }
        public string UsedTables { get; set; }
        public string MwColumns { get; set; }

        public virtual ICollection<ReportFilters> ReportFilters { get; set; }
    }
}
