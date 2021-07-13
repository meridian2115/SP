using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class DcRefInstitutions
    {
        public DcRefInstitutions()
        {
            FsOkvedInstList = new HashSet<FsOkvedInstList>();
        }

        public decimal Docid { get; set; }
        public decimal? Version { get; set; }
        public string Code { get; set; }
        public string Fullname { get; set; }
        public string Shortname { get; set; }
        public string Type { get; set; }
        public string OrfkId { get; set; }
        public string OrgCode { get; set; }
        public string OrgName { get; set; }
        public string Indtxpridntnm { get; set; }
        public string Cdrsnrg { get; set; }
        public string Cdnceo { get; set; }
        public string OktmoCdoktmo { get; set; }
        public string Nmelpublglstr { get; set; }
        public string Address { get; set; }
        public bool? Chfmngbdg { get; set; }
        public bool? Recbudg { get; set; }
        public bool? Othrecbudg { get; set; }
        public bool? Cabr { get; set; }
        public bool? Abr { get; set; }
        public bool? Caisfbd { get; set; }
        public bool? Caesfbd { get; set; }
        public bool? Aisfbd { get; set; }
        public bool? Aesfbd { get; set; }
        public bool? Tmpmngrbdgt { get; set; }
        public string Note { get; set; }
        public string ChapterCodechapter { get; set; }
        public string ChapterNamechapter { get; set; }
        public string FinauthCdfinauth { get; set; }
        public string FinauthNmfinauth { get; set; }
        public string TerelfedtrCdterelfedtr { get; set; }
        public string TerelfedtrNmterelfedtr { get; set; }
        public string FoundersCodefounder { get; set; }
        public string FoundersNamefounder { get; set; }
        public bool? Finorg { get; set; }
        public string BudgetsBudgetcode { get; set; }
        public string BudgetsBudgetname { get; set; }
        public bool? Detachedsubdivision { get; set; }
        public string HomeorgCdhomeorg { get; set; }
        public string HomeorgNmhomeorg { get; set; }
        public string FounderCdfounder { get; set; }
        public string FounderNmfounder { get; set; }
        public string Ogrn { get; set; }
        public string OrgGuid { get; set; }
        public DateTime? DataStartactive { get; set; }
        public DateTime? DataEndactive { get; set; }
        public bool? Centr { get; set; }
        public string Cdsr { get; set; }
        public string Egrul { get; set; }
        public string Egrp { get; set; }
        public string CdSr1 { get; set; }
        public bool? Sobf { get; set; }
        public bool? Tsobf { get; set; }
        public string CodekofkSobstv { get; set; }
        public string Guidnsi { get; set; }
        public string UpCd { get; set; }
        public string UpNm { get; set; }
        public bool? Ckmenuorg { get; set; }
        public string OkvedcodeCode { get; set; }
        public string OkvedcodeName { get; set; }

        public virtual ICollection<FsOkvedInstList> FsOkvedInstList { get; set; }
    }
}
