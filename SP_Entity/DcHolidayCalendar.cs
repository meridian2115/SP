using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class DcHolidayCalendar
    {
        public DcHolidayCalendar()
        {
            FsIndustrialList = new HashSet<FsIndustrialList>();
        }

        public decimal Docid { get; set; }
        public decimal? Version { get; set; }
        public decimal? Year { get; set; }

        public virtual ICollection<FsIndustrialList> FsIndustrialList { get; set; }
    }
}
