using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class HRefAcctgntries
    {
        public decimal Id { get; set; }
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
        public string Note { get; set; }
    }
}
