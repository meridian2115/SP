﻿using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class DwarpReport0507011
    {
        public Guid Uuid { get; set; }
        public int? Year { get; set; }
        public DateTime? ReportDate { get; set; }
        public string DateStr { get; set; }
        public short? PeriodType { get; set; }
        public string SvrCode { get; set; }
        public string GrbsCode { get; set; }
        public string SectionCode { get; set; }
        public string TargetCode { get; set; }
        public string ExpCode { get; set; }
        public decimal? Dat6 { get; set; }
        public decimal? Dat7 { get; set; }
        public decimal? Dat8 { get; set; }
        public short? Accesslevel { get; set; }
        public short? IsMigration { get; set; }
    }
}
