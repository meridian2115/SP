using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class DwvlsReport0531758
    {
        public Guid Uuid { get; set; }
        public int? Year { get; set; }
        public DateTime? ReportDate { get; set; }
        public string GrbsCode { get; set; }
        public string SvrCode { get; set; }
        public string AccGrbs { get; set; }
        public DateTime? Dim2 { get; set; }
        public decimal? Dat3 { get; set; }
        public decimal? Dat4 { get; set; }
        public decimal? Dat5 { get; set; }
        public decimal? Dat6 { get; set; }
        public Guid? UuidPril { get; set; }
        public short? Accesslevel { get; set; }
        public short? IsMigration { get; set; }
    }
}
