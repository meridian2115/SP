using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class FsClClList
    {
        public decimal? Docid { get; set; }
        public decimal? Tablerownum { get; set; }
        public decimal Fieldsetid { get; set; }
        public string C1R3 { get; set; }
        public string C2R3Num { get; set; }
        public decimal? C3R3 { get; set; }
        public decimal? C4R3 { get; set; }
        public decimal? C5R3 { get; set; }
        public decimal? C6R3 { get; set; }
        public decimal? C7R3 { get; set; }
        public decimal? C8R3 { get; set; }
        public decimal? C9R3 { get; set; }
        public decimal? C10R3 { get; set; }

        public virtual DcArprep0503730 Doc { get; set; }
    }
}
