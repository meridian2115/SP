using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class DwspKpeVer1
    {
        public Guid Uuid { get; set; }
        public int? Year { get; set; }
        public DateTime? ReportDate { get; set; }
        public short? PeriodType { get; set; }
        public string SvrCode { get; set; }
        public string GrbsCode { get; set; }
        public string SectSubsect { get; set; }
        public string SectCode { get; set; }
        public string SubsectCode { get; set; }
        public string TargetCode { get; set; }
        public string ExpCode { get; set; }
        public string Kosgu { get; set; }
        public decimal? DatLbo { get; set; }
        public decimal? DatKassa { get; set; }
        public short? Accesslevel { get; set; }
        public short? IsMigration { get; set; }
    }
}
