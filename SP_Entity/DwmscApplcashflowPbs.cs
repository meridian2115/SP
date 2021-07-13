using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class DwmscApplcashflowPbs
    {
        public Guid Uuid { get; set; }
        public int? Year { get; set; }
        public DateTime? ReportDate { get; set; }
        public DateTime? IspDate { get; set; }
        public string SvrCode { get; set; }
        public string DocNum { get; set; }
        public string KbkType { get; set; }
        public string GrbsCode { get; set; }
        public string SectCode { get; set; }
        public string TargetCode { get; set; }
        public string ExpCode { get; set; }
        public string Kod17 { get; set; }
        public string ContName { get; set; }
        public string AccNum { get; set; }
        public string PayPurpose { get; set; }
        public string CurrCode { get; set; }
        public decimal? Dat1 { get; set; }
        public int? IsMigration { get; set; }
        public int? Accesslevel { get; set; }
    }
}
