using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class DcArpFahPosting
    {
        public DcArpFahPosting()
        {
            FsResultList = new HashSet<FsResultList>();
        }

        public decimal Docid { get; set; }
        public decimal? Version { get; set; }
        public DateTime? DataStartactive { get; set; }
        public DateTime? DataEndactive { get; set; }
        public string Login { get; set; }
        public string Org { get; set; }
        public string PTofkCode { get; set; }
        public string PDocType { get; set; }
        public string PDocGroup { get; set; }
        public string PFundActivities { get; set; }
        public DateTime? PLedgerId { get; set; }
        public string PBudgetCode { get; set; }
        public string PDrAccount { get; set; }
        public string PCrAccount { get; set; }
        public string PDrBcc { get; set; }
        public string PCrBcc { get; set; }
        public string PDrPa { get; set; }
        public string PCrPa { get; set; }
        public string PDrBankPa { get; set; }
        public string PCrBankPa { get; set; }
        public string PDrBccType { get; set; }
        public string PCrBccType { get; set; }
        public string POperationType { get; set; }
        public string PCodeLedger { get; set; }
        public string Vv { get; set; }
        public string VTofk { get; set; }
        public string PTofkCodeh { get; set; }
        public string POebsLink { get; set; }

        public virtual ICollection<FsResultList> FsResultList { get; set; }
    }
}
