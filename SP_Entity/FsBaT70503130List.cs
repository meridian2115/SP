using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class FsBaT70503130List
    {
        public decimal? Docid { get; set; }
        public decimal? Tablerownum { get; set; }
        public decimal Fieldsetid { get; set; }
        public string C2R2101 { get; set; }
        public decimal? C4R2101 { get; set; }
        public decimal? C5R2101 { get; set; }

        public virtual DcArpbalance0503130 Doc { get; set; }
    }
}
