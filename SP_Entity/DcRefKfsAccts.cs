using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class DcRefKfsAccts
    {
        public decimal Docid { get; set; }
        public decimal? Version { get; set; }
        public string AcctCd { get; set; }
        public string AcctCdGuid { get; set; }
        public string KfsCd { get; set; }
        public string KfsNm { get; set; }
        public bool? Ti { get; set; }
        public bool? Bi { get; set; }
        public bool? Ai { get; set; }
        public string Note { get; set; }
        public DateTime? DataStartactive { get; set; }
        public DateTime? DataEndactive { get; set; }
    }
}
