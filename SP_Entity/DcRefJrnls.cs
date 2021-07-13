using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class DcRefJrnls
    {
        public decimal Docid { get; set; }
        public decimal? Version { get; set; }
        public string Nb { get; set; }
        public string Nm { get; set; }
        public string PrntNb { get; set; }
        public string PrntNm { get; set; }
        public string Prty { get; set; }
        public string FeatrNm { get; set; }
        public string FeatrNmGuid { get; set; }
        public string GrpFeatrNm { get; set; }
        public string GrpFeatrNmGuid { get; set; }
        public string Note { get; set; }
    }
}
