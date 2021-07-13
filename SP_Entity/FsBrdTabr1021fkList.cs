using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class FsBrdTabr1021fkList
    {
        public decimal? Docid { get; set; }
        public decimal? Tablerownum { get; set; }
        public decimal Fieldsetid { get; set; }
        public string C1R0101 { get; set; }
        public string C2R0101 { get; set; }
        public string C2bR0101 { get; set; }
        public decimal? C3R0101 { get; set; }
        public decimal? C4R0101 { get; set; }
        public decimal? C5R0101 { get; set; }
        public decimal? C6R0101 { get; set; }
        public decimal? C7R0101 { get; set; }
        public string Marker010 { get; set; }

        public virtual DcArpReport0507021Fk Doc { get; set; }
    }
}
