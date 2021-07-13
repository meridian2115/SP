using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class DictChkLog
    {
        public DateTime? LogTime { get; set; }
        public string DictMigr { get; set; }
        public string DictUfos { get; set; }
        public string FieldUfos { get; set; }
        public int? Year { get; set; }
        public bool? Inver { get; set; }
        public bool? DfName { get; set; }
        public bool? DfDateActive { get; set; }
        public string UslUfos { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public string TypeMess { get; set; }
        public string Message { get; set; }
        public string CodeParent { get; set; }
        public DateTime? BeginDate { get; set; }
        public DateTime? EndDate { get; set; }
        public string UfosCode { get; set; }
        public string UfosName { get; set; }
        public string UfosCodeParent { get; set; }
        public DateTime? UfosBeginDate { get; set; }
        public DateTime? UfosEndDate { get; set; }
        public bool? DataFix { get; set; }
        public decimal? LogId { get; set; }
    }
}
