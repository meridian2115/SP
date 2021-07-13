using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class DcRefCsmocacct
    {
        public decimal Docid { get; set; }
        public decimal? Version { get; set; }
        public string AcctCd { get; set; }
        public string AcctCdguid { get; set; }
        public string CsmocckieCd { get; set; }
        public string CsmocckieCdguid { get; set; }
        public bool? Ti { get; set; }
        public bool? Bi { get; set; }
        public bool? Ai { get; set; }
        public string Note { get; set; }
        public string Kind { get; set; }
        public string Cdbu { get; set; }
        public DateTime? DataStartactive { get; set; }
        public DateTime? DataEndactive { get; set; }
        public string Cdaccunt { get; set; }
        public string Upcd { get; set; }
        public string CsmocckieNm { get; set; }
    }
}
