using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class DcUnitedimportdialog
    {
        public decimal Docid { get; set; }
        public decimal? Version { get; set; }
        public string HrFormname { get; set; }
        public bool? HrChangeinlow { get; set; }
        public string HrSysformname { get; set; }
        public string HrPeriod { get; set; }
        public string HrYear { get; set; }
        public string HrImportformat { get; set; }
        public bool? HrPed { get; set; }
        public string HrSecretlevel { get; set; }
        public DateTime? HrReportDate { get; set; }
        public DateTime? HrDocdate { get; set; }
        public string HrSecret { get; set; }
        public string UpdverparNeworupdate { get; set; }
        public string UpdverparName { get; set; }
        public DateTime? UpdverparLastupdate { get; set; }
        public string UpdverparUpdoptions { get; set; }
        public string InfoverName { get; set; }
        public DateTime? InfoverLastupdate { get; set; }
        public string InfoverDescription { get; set; }
        public string InfoverPath { get; set; }
        public bool? ErrFlag { get; set; }
        public string ErrText { get; set; }
        public string HrPeriodtype { get; set; }
        public string HrMonth { get; set; }
        public string HrDay { get; set; }
    }
}
