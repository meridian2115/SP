using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class DcRefBudgets
    {
        public decimal Docid { get; set; }
        public decimal? Version { get; set; }
        public string Guid { get; set; }
        public string TofkcodeCode { get; set; }
        public DateTime? Opendate { get; set; }
        public DateTime? Closedate { get; set; }
        public DateTime? Startdateactive { get; set; }
        public DateTime? Enddateactive { get; set; }
        public string Budgetstatus { get; set; }
        public string Status { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public string ParentcodeCode { get; set; }
        public string BudglevelcodeCode { get; set; }
        public string BudgtypecodeCode { get; set; }
        public string OkatocodeCode { get; set; }
        public string OktmocodeCode { get; set; }
        public string FoorgcodeCode { get; set; }
        public string FoorgcodeubpCode { get; set; }
        public string Tofkname { get; set; }
    }
}
