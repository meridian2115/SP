using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class DcRefAcctgntries
    {
        public decimal Docid { get; set; }
        public decimal? Version { get; set; }
        public string Cd { get; set; }
        public string Nm { get; set; }
        public string PwrsCd { get; set; }
        public string TpCsieDtCdGuid { get; set; }
        public string SnthtcAcctDtCdGuid { get; set; }
        public string CsmocCkieDtCdGuid { get; set; }
        public string TpCsieKtCdGuid { get; set; }
        public string SnthtcAcctKtCdGuid { get; set; }
        public string CsmocCkieKtCdGuid { get; set; }
        public string JrnlNbGuid { get; set; }
        public string TpCsieDtCd { get; set; }
        public string SnthtcAcctDtCd { get; set; }
        public string CsDtCsDtCd { get; set; }
        public string TpCsieKtCd { get; set; }
        public string SnthtcAcctKtCd { get; set; }
        public string CsKtCsKtCd { get; set; }
        public string JrnlNb { get; set; }
        public string Note { get; set; }
        public string Pr1Cd { get; set; }
        public string Pr2Cd2 { get; set; }
        public DateTime? DataStartactive { get; set; }
        public DateTime? DataEndactive { get; set; }
    }
}
