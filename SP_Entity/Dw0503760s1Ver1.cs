using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class Dw0503760s1Ver1
    {
        public Guid Uuid { get; set; }
        public int? Year { get; set; }
        public DateTime? ReportDate { get; set; }
        public string GrbsCode { get; set; }
        public short? PeriodType { get; set; }
        public string SvrCode { get; set; }
        public string Link { get; set; }
        public short? Accesslevel { get; set; }
        public short? IsMigration { get; set; }
    }
}
