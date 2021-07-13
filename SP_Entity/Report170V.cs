﻿using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class Report170V
    {
        public Guid? Uuid { get; set; }
        public int? Year { get; set; }
        public DateTime? ReportDate { get; set; }
        public string CodeGp { get; set; }
        public int? PeriodType { get; set; }
        public string SvrCode { get; set; }
        public string Dim3 { get; set; }
        public string Dim4 { get; set; }
        public decimal? Dat5 { get; set; }
        public decimal? Dat6 { get; set; }
        public decimal? Dat7 { get; set; }
        public decimal? Dat8 { get; set; }
        public decimal? Dat9 { get; set; }
        public short? Accesslevel { get; set; }
        public short? IsMigration { get; set; }
    }
}
