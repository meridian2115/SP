using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class DcNatClassUnits
    {
        public decimal Docid { get; set; }
        public decimal? Version { get; set; }
        public string ViewUnit { get; set; }
        public string TypeUnit { get; set; }
        public string CodeUnit { get; set; }
        public string NameUnit { get; set; }
        public string NationalLeg { get; set; }
        public string IntLeg { get; set; }
        public string NationalSym { get; set; }
        public string IntSym { get; set; }
        public string Note { get; set; }
        public DateTime? DataStartactive { get; set; }
        public DateTime? DataEndactive { get; set; }
        public string Guidnsi { get; set; }
    }
}
