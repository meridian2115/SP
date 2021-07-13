using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class HExpInfbo
    {
        public HExpInfbo()
        {
            HfsAgiTehDecAgreerList = new HashSet<HfsAgiTehDecAgreerList>();
            HfsBoAgreerList = new HashSet<HfsBoAgreerList>();
            HfsOsPaymnList = new HashSet<HfsOsPaymnList>();
            HfsOsResList = new HashSet<HfsOsResList>();
            HfsRtTablsubsidList = new HashSet<HfsRtTablsubsidList>();
        }

        public decimal Id { get; set; }
        public string InfNumberdocument { get; set; }
        public DateTime? InfDatedocument { get; set; }
        public string InfTypedocument { get; set; }
        public string InfNumberchange { get; set; }
        public string InfNotecancel { get; set; }
        public string RbNamerecip { get; set; }
        public string RbCodegrbs { get; set; }
        public string RbNumberaccount { get; set; }
        public string RbGlavabkcode { get; set; }
        public string RbGrbs { get; set; }
        public string RbNamebudget { get; set; }
        public string RbCodetofk { get; set; }
        public string RbNametofk { get; set; }
        public string RbUniccodeorg { get; set; }
        public string IdbRoomact { get; set; }
        public DateTime? IdbDatecontract { get; set; }
        public decimal? IdbSumsubsid { get; set; }
        public decimal? IdbSumsubsrub { get; set; }
        public decimal? IdbCourseTech { get; set; }
        public decimal? IdbSumsubsidTech { get; set; }
        public DateTime? MfkDateregis { get; set; }
        public DateTime? MfkDatesigning { get; set; }
        public string SgNamehead { get; set; }
        public string SgPosthead { get; set; }
        public DateTime? SgDatesigning { get; set; }
        public string SgNamerespon { get; set; }
        public string SgPostrespon { get; set; }
        public DateTime? SgDatesigcharge { get; set; }
        public string LaNameexec { get; set; }
        public string LaPostexec { get; set; }
        public DateTime? LaDatesignexec { get; set; }
        public string LaNameheadutv { get; set; }
        public string LaPostheadutv { get; set; }
        public DateTime? LaDatesignutv { get; set; }
        public string LaNote { get; set; }
        public string SiUserflag2 { get; set; }
        public DateTime? SiApproverStartdate { get; set; }
        public decimal? SourceId { get; set; }

        public virtual ICollection<HfsAgiTehDecAgreerList> HfsAgiTehDecAgreerList { get; set; }
        public virtual ICollection<HfsBoAgreerList> HfsBoAgreerList { get; set; }
        public virtual ICollection<HfsOsPaymnList> HfsOsPaymnList { get; set; }
        public virtual ICollection<HfsOsResList> HfsOsResList { get; set; }
        public virtual ICollection<HfsRtTablsubsidList> HfsRtTablsubsidList { get; set; }
    }
}
