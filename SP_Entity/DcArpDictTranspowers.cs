using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class DcArpDictTranspowers
    {
        public decimal Docid { get; set; }
        public decimal? Version { get; set; }
        public DateTime? DataStartactive { get; set; }
        public DateTime? DataEndactive { get; set; }
        public DateTime? Dateagreement { get; set; }
        public DateTime? Endactiveagreement { get; set; }
        public string Numberagreement { get; set; }
        public string Codesvrcb { get; set; }
        public string Fullnamecb { get; set; }
        public string Codesvrorg { get; set; }
        public string Fullnameorg { get; set; }
        public string Nameagreement { get; set; }
        public string Basicprovagreement { get; set; }
        public string Nameleadercb { get; set; }
        public string Nameleaderorg { get; set; }
        public string Legaladdresscb { get; set; }
        public string Legaladdressorg { get; set; }
    }
}
