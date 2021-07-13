using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class FsSfR3710List
    {
        public decimal? Docid { get; set; }
        public decimal? Tablerownum { get; set; }
        public decimal Fieldsetid { get; set; }
        public string C1R7101 { get; set; }
        public string C2R7101 { get; set; }
        public string C3R7101 { get; set; }
        public string C3aR7101 { get; set; }
        public string C3bR7101 { get; set; }
        public decimal? C4R7101 { get; set; }
        public decimal? C5R7101 { get; set; }
        public decimal? C6R7101 { get; set; }
        public decimal? C7R7101 { get; set; }
        public string Num710 { get; set; }
        public string Marker710 { get; set; }

        public virtual DcReport0503117 Doc { get; set; }
    }
}
