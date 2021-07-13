using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class FsSfDom0503163List
    {
        public decimal? Docid { get; set; }
        public decimal? Tablerownum { get; set; }
        public decimal Fieldsetid { get; set; }
        public string C1R5001 { get; set; }
        public string C1aR50011 { get; set; }
        public string C1bR50012 { get; set; }
        public decimal? C2R5001 { get; set; }
        public decimal? C3R5001 { get; set; }
        public decimal? C4R5001 { get; set; }
        public string C5R5001 { get; set; }
        public string C5aR5001 { get; set; }
        public string C5bR5001 { get; set; }
        public string C1b1R50012 { get; set; }
        public string C1b2R50012 { get; set; }
        public string C1b3R50012 { get; set; }
        public string C1b4R50012 { get; set; }
        public string C1b5R50012 { get; set; }
        public string KbkR5001 { get; set; }

        public virtual DcReport0503163 Doc { get; set; }
    }
}
