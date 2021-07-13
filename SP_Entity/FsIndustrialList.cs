using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class FsIndustrialList
    {
        public decimal? Docid { get; set; }
        public decimal? Tablerownum { get; set; }
        public decimal Fieldsetid { get; set; }
        public DateTime? IndustrialDay { get; set; }
        public string HolidayName { get; set; }
        public string Region { get; set; }
        public bool? IsWorkDay { get; set; }
        public bool? IsHoliday { get; set; }

        public virtual DcHolidayCalendar Doc { get; set; }
    }
}
