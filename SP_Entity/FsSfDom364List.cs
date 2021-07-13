using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class FsSfDom364List
    {
        public decimal? Docid { get; set; }
        public decimal? Tablerownum { get; set; }
        public decimal Fieldsetid { get; set; }
        public string C1R5201 { get; set; }
        public string C2R5201 { get; set; }
        public string C1aR52011 { get; set; }
        public string C1bR52012 { get; set; }
        public string C1cR520 { get; set; }
        public string C1dR5201 { get; set; }
        public string C1eR5201 { get; set; }
        public decimal? C3R5201 { get; set; }
        public decimal? C4R5201 { get; set; }
        public decimal? C5R5201 { get; set; }
        public decimal? C6R5201 { get; set; }
        public decimal? C7R5201 { get; set; }
        public string C8R5201 { get; set; }
        public string C9R5201 { get; set; }
        public string Nmsubjreport520 { get; set; }
        public string NumString3 { get; set; }

        public virtual DcArpReport0503364 Doc { get; set; }
    }
}
