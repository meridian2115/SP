using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class DcRefJrnlsacct
    {
        public decimal Docid { get; set; }
        public decimal? Version { get; set; }
        public string AcctCd { get; set; }
        public string AcctCdGuid { get; set; }
        public string JrnlNb { get; set; }
        public string JrnlNm { get; set; }
        public string JrnlNbGuid { get; set; }
        public string Note { get; set; }
    }
}
