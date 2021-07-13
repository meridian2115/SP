using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class DcRegisterOfOperations
    {
        public decimal Docid { get; set; }
        public decimal? Version { get; set; }
        public string Code { get; set; }
        public string RegisterCode { get; set; }
        public string ParentRegisterCode { get; set; }
        public string RegisterName { get; set; }
        public string Priority { get; set; }
        public string TypeOfVisibility { get; set; }
        public string InstitutionCode { get; set; }
        public string Institution { get; set; }
        public string Note { get; set; }
        public DateTime? PeriodFromDate { get; set; }
        public DateTime? PeriodToDate { get; set; }
    }
}
