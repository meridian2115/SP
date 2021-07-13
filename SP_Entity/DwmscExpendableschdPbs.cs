﻿using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class DwmscExpendableschdPbs
    {
        public Guid Uuid { get; set; }
        public int? Year { get; set; }
        public DateTime? DocDate { get; set; }
        public DateTime? ReportDate { get; set; }
        public DateTime? OperDate { get; set; }
        public string SvrCode { get; set; }
        public string DocNumber { get; set; }
        public string GrbsCode { get; set; }
        public string SectCode { get; set; }
        public string TargetCode { get; set; }
        public string ExpCode { get; set; }
        public string AprCode { get; set; }
        public string TofkCode { get; set; }
        public string SubjCode { get; set; }
        public string SpecCode { get; set; }
        public string Status { get; set; }
        public decimal? SumYear { get; set; }
        public decimal? SumYear1 { get; set; }
        public decimal? SumYear2 { get; set; }
        public string Rzd { get; set; }
        public short? Accesslevel { get; set; }
        public short? IsMigration { get; set; }
    }
}