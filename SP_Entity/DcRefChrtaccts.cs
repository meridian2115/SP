using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class DcRefChrtaccts
    {
        public decimal Docid { get; set; }
        public decimal? Version { get; set; }
        public string ChrtaccttpCd { get; set; }
        public string Cd { get; set; }
        public string Nm { get; set; }
        public string Tp { get; set; }
        public string PrntCd { get; set; }
        public string PrntNm { get; set; }
        public bool? Ti { get; set; }
        public bool? Bi { get; set; }
        public bool? Ai { get; set; }
        public bool? Qtyacct { get; set; }
        public bool? Offbalacct { get; set; }
        public bool? Ccyacct { get; set; }
        public bool? Storbalcsmocckie { get; set; }
        public bool? Usinacctnntries { get; set; }
        public string Note { get; set; }
        public DateTime? DataStartactive { get; set; }
        public DateTime? DataEndactive { get; set; }
    }
}
