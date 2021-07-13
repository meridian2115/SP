using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class Dwdc17reportslbo
    {
        public Guid Uuid { get; set; }
        public int? Year { get; set; }
        public int? Year1 { get; set; }
        public int? Year2 { get; set; }
        public DateTime? ReportDate { get; set; }
        public short? PeriodType { get; set; }
        public string SvrCode { get; set; }
        public string TypeChange { get; set; }
        public string Nameindicat { get; set; }
        public string GrbsCode { get; set; }
        public string Sect { get; set; }
        public string Subsect { get; set; }
        public string SectionCode { get; set; }
        public string TargetCode { get; set; }
        public string ExpCode { get; set; }
        public bool? DetalKbk { get; set; }
        public decimal? Dat10 { get; set; }
        public decimal? Dat11 { get; set; }
        public decimal? Dat12 { get; set; }
        public decimal? Dat21 { get; set; }
        public decimal? Dat22 { get; set; }
        public decimal? Dat23 { get; set; }
        public decimal? Dat31 { get; set; }
        public decimal? Dat32 { get; set; }
        public decimal? Dat33 { get; set; }
        public short? Accesslevel { get; set; }
        public short? IsMigration { get; set; }
    }
}
