﻿using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class DwdbdBudginventLaws1Ver1
    {
        public Guid Uuid { get; set; }
        public short? IsTotal { get; set; }
        public DateTime? ReportDate { get; set; }
        public int? Year { get; set; }
        public short? PeriodType { get; set; }
        public string SvrCode { get; set; }
        public DateTime? DateApp { get; set; }
        public string Target { get; set; }
        public string Dim1 { get; set; }
        public string Dim2 { get; set; }
        public string Dim3 { get; set; }
        public string Dim4 { get; set; }
        public string Dim5 { get; set; }
        public decimal? Dat6 { get; set; }
        public decimal? Dat7 { get; set; }
        public decimal? Dat8 { get; set; }
        public short? Accesslevel { get; set; }
        public short? IsMigration { get; set; }
    }
}
