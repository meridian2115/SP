using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class DcArpOrdpresgov
    {
        public decimal Docid { get; set; }
        public decimal? Version { get; set; }
        public string Nb { get; set; }
        public DateTime? Dt { get; set; }
        public string Pt { get; set; }
        public string Gl { get; set; }
        public decimal? Pr { get; set; }
        public string Cf { get; set; }
        public string Nf { get; set; }
        public string Cnp { get; set; }
        public string Tempf { get; set; }
        public DateTime? DataStartactive { get; set; }
        public DateTime? DataEndactive { get; set; }
        public string Note { get; set; }
    }
}
