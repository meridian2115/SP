using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class DcSubjectsReporting
    {
        public DcSubjectsReporting()
        {
            FsCmReportingLevelList = new HashSet<FsCmReportingLevelList>();
            FsReAssigneeList = new HashSet<FsReAssigneeList>();
        }

        public decimal Docid { get; set; }
        public decimal? Version { get; set; }
        public string Cdsubjreport { get; set; }
        public string Cdalt { get; set; }
        public string Nmsubjreport { get; set; }
        public string TpsrTpsubjreport { get; set; }
        public string InstCode { get; set; }
        public string InstFullName { get; set; }
        public string InstName { get; set; }
        public string InstSr { get; set; }
        public string InstInn { get; set; }
        public string InstKpp { get; set; }
        public string PrPrcdalt { get; set; }
        public string PrPrcd { get; set; }
        public string PrPrnm { get; set; }
        public string PrPrtp { get; set; }
        public string FdNmfdrdst { get; set; }
        public string Codefd { get; set; }
        public string Note { get; set; }
        public DateTime? DataStartactive { get; set; }
        public DateTime? DataEndactive { get; set; }
        public string ChapterCodechapter { get; set; }
        public string ChapterNamechapter { get; set; }
        public string OktmoSr { get; set; }
        public string CodetofkSr { get; set; }
        public string CodepSr { get; set; }
        public string CaFullname { get; set; }
        public string CaCdSr { get; set; }
        public string SrfCd { get; set; }
        public string SrfNm { get; set; }
        public bool? Out { get; set; }
        public bool? Stat { get; set; }
        public bool? IsOrgTested { get; set; }
        public bool? Ckmenusubj { get; set; }
        public bool? IsZagranOrg { get; set; }
        public string NameZagran { get; set; }
        public string CdSrZagran { get; set; }
        public bool? IsReorg { get; set; }
        public string ReType { get; set; }
        public string ReDecision { get; set; }
        public string ReReason { get; set; }
        public DateTime? ReStartDate { get; set; }
        public DateTime? ReEndDate { get; set; }
        public string ReNote { get; set; }
        public bool? ReIsSvod { get; set; }
        public bool? ReAsEmpty { get; set; }
        public string OkvedcodeCode { get; set; }
        public string OkvedcodeName { get; set; }
        public bool? AllowImp { get; set; }
        public bool? CmIsCompetency { get; set; }

        public virtual ICollection<FsCmReportingLevelList> FsCmReportingLevelList { get; set; }
        public virtual ICollection<FsReAssigneeList> FsReAssigneeList { get; set; }
    }
}
