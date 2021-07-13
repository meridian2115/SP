using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class DcRefCsmocckieParamV
    {
        public decimal? Docid { get; set; }
        public decimal? Version { get; set; }
        public string Cd { get; set; }
        public string Nm { get; set; }
        public bool? Cshtrnsctns { get; set; }
        public string PrntCd { get; set; }
        public string PrntNm { get; set; }
        public string Note { get; set; }
        public DateTime? DataStartactive { get; set; }
        public DateTime? DataEndactive { get; set; }
        public string Guidnsi { get; set; }
        public string Type { get; set; }
    }
}
