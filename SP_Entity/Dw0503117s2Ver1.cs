using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class Dw0503117s2Ver1
    {
        public Guid Uuid { get; set; }
        public DateTime? ReportDate { get; set; }
        public int? Year { get; set; }
        public string PeriodType { get; set; }
        public string GrbsCode { get; set; }
        public decimal? Dat1 { get; set; }
        public decimal? Dat2 { get; set; }
        public decimal? Dat3 { get; set; }
        public short? IsTotal { get; set; }
        public short? Accesslevel { get; set; }
        public short? IsMigration { get; set; }
    }
}
