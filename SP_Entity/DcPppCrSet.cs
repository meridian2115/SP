using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class DcPppCrSet
    {
        public DcPppCrSet()
        {
            FsTbldocList = new HashSet<FsTbldocList>();
            FsTblfilterList = new HashSet<FsTblfilterList>();
            FsTblleftList = new HashSet<FsTblleftList>();
            FsTblopercrList = new HashSet<FsTblopercrList>();
            FsTblparamList = new HashSet<FsTblparamList>();
            FsTblrightList = new HashSet<FsTblrightList>();
            FsTblvariableList = new HashSet<FsTblvariableList>();
        }

        public decimal Docid { get; set; }
        public decimal? Version { get; set; }
        public string SpecmethChckmethod { get; set; }
        public string SpecmethExpression { get; set; }
        public string SpecmethFormulan1 { get; set; }
        public string SpecmethFormulan1name { get; set; }
        public string SpecmethFormulan2 { get; set; }
        public string SpecmethFormulan2name { get; set; }
        public string SpecmethFiltercurr { get; set; }
        public string SpecmethTabledoc { get; set; }
        public string SpecmethGroupfield { get; set; }
        public DateTime? SpecmethPositionstart { get; set; }
        public DateTime? SpecmethPositionend { get; set; }
        public string SpecmethGroupvalue { get; set; }
        public string SpecmethGroupvalueex { get; set; }
        public string SpecmethLeft { get; set; }
        public string SpecmethRight { get; set; }
        public string SpecmethOperation { get; set; }
        public string SpecmethCodecr { get; set; }
        public string SpecmethErrfieldtable { get; set; }
        public string SpecmethErrfielddoc { get; set; }
        public string SpecmethErrexpr { get; set; }
        public string SpecmethErrortext { get; set; }
        public string SpecmethChecktype { get; set; }
        public bool? SpecmethDaily { get; set; }
        public bool? SpecmethKvart { get; set; }
        public bool? SpecmethMount { get; set; }
        public bool? SpecmethHalfy { get; set; }
        public bool? SpecmethYear { get; set; }
        public DateTime? SpecmethProizv { get; set; }
        public bool? SpecmethNadatu { get; set; }
        public string SpecmethTemp1 { get; set; }
        public string SpecmethTemp2 { get; set; }
        public string SpecmethTemp3 { get; set; }
        public string SpecmethTemp4 { get; set; }
        public string SpecmethTemp5 { get; set; }
        public string SpecmethTemp6 { get; set; }
        public string SpecmethPeriod { get; set; }
        public string Nmbr { get; set; }
        public string Code { get; set; }
        public string Type { get; set; }
        public string Codereportform { get; set; }
        public string AiCode { get; set; }
        public string AiName { get; set; }
        public string Method { get; set; }
        public string Addvalues { get; set; }
        public DateTime? DataStartactive { get; set; }
        public DateTime? DataEndactive { get; set; }

        public virtual ICollection<FsTbldocList> FsTbldocList { get; set; }
        public virtual ICollection<FsTblfilterList> FsTblfilterList { get; set; }
        public virtual ICollection<FsTblleftList> FsTblleftList { get; set; }
        public virtual ICollection<FsTblopercrList> FsTblopercrList { get; set; }
        public virtual ICollection<FsTblparamList> FsTblparamList { get; set; }
        public virtual ICollection<FsTblrightList> FsTblrightList { get; set; }
        public virtual ICollection<FsTblvariableList> FsTblvariableList { get; set; }
    }
}
