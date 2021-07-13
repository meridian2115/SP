using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class DcRefBankaccounts
    {
        public decimal Docid { get; set; }
        public decimal? Version { get; set; }
        public string Accountnumber { get; set; }
        public string Bankidcode { get; set; }
        public string Bankname { get; set; }
        public string Bankaddress { get; set; }
        public string Corraccount { get; set; }
        public string Note { get; set; }
        public string AccountownerOwnercode { get; set; }
        public string AccountownerOwnername { get; set; }
        public DateTime? DataStartactive { get; set; }
        public DateTime? DataEndactive { get; set; }
        public string AcctCd { get; set; }
        public string Guidnsi { get; set; }
    }
}
