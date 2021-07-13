using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class DcRefKbkglava
    {
        public decimal Docid { get; set; }
        public decimal? Version { get; set; }
        public string Guid { get; set; }
        public DateTime? Startdateactive { get; set; }
        public DateTime? Enddateactive { get; set; }
        public string Status { get; set; }
        public string Code { get; set; }
        public string Shortname { get; set; }
        public string Fullname { get; set; }
        public string ParentcodeCode { get; set; }
        public string ParentcodeShortname { get; set; }
        public string BudgcodeCode { get; set; }
        public string BudgcodeName { get; set; }
        public string TofkcodeCode { get; set; }
        public string TofkcodeShortname { get; set; }
        public DateTime? Dateinclusion { get; set; }
        public DateTime? Dateexclusion { get; set; }
        public string Kbkglavastatus { get; set; }
        public string Sistema { get; set; }
        public bool? Bkisapproved { get; set; }
        public string Idminfin { get; set; }
        public string Metaidminfin { get; set; }
        public string Stagesbudgetcycle { get; set; }
        public bool? Isgrbs { get; set; }
        public bool? Isgad { get; set; }
        public bool? Isgaifdb { get; set; }
        public string Progenitorcode { get; set; }
        public bool? Islimitsuse { get; set; }
        public string PMetaidminfin2 { get; set; }
        public DateTime? DocDateofsigning { get; set; }
        public string DocDocname { get; set; }
        public string DocDocnumber { get; set; }
        public decimal? Id205 { get; set; }
        public bool? Isconditional { get; set; }
        public string Overseesdepartment { get; set; }
        public decimal? Reductionfoiv { get; set; }
        public decimal? Syscode { get; set; }
        public string Typesofbudget { get; set; }
        public decimal? RsnRCode { get; set; }
        public DateTime? RsnRDateend { get; set; }
        public DateTime? RsnRDatesigning { get; set; }
        public DateTime? RsnRDatestart { get; set; }
        public string RsnRId { get; set; }
        public string RsnRMetaid { get; set; }
        public string RsnRName { get; set; }
        public string RsnRNumber { get; set; }
        public string RsnRReasontype { get; set; }
        public string Keydate { get; set; }
    }
}
