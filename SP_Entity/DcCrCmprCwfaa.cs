using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class DcCrCmprCwfaa
    {
        public decimal Docid { get; set; }
        public decimal? Version { get; set; }
        public string Compare { get; set; }
        public string Tabledoc { get; set; }
        public string Groupfield { get; set; }
        public DateTime? Positionstart { get; set; }
        public DateTime? Positionend { get; set; }
        public string Groupvalue { get; set; }
        public string Groupvalueex { get; set; }
        public string Crutch { get; set; }
    }
}
