using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class FsSf1T3021fkList
    {
        public decimal? Docid { get; set; }
        public decimal? Tablerownum { get; set; }
        public decimal Fieldsetid { get; set; }
        public string C1R5001 { get; set; }
        public string C2R5001 { get; set; }
        public string C2bR5001 { get; set; }
        public decimal? C3R5001 { get; set; }
        public decimal? C4R5001 { get; set; }
        public decimal? C5R5001 { get; set; }
        public decimal? C6R5001 { get; set; }
        public decimal? C7R5001 { get; set; }
        public string Marker500 { get; set; }

        public virtual DcArpReport0507021Fk Doc { get; set; }
    }
}
