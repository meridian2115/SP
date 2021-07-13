using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class FsAdebtTable050List
    {
        public decimal? Docid { get; set; }
        public decimal? Tablerownum { get; set; }
        public decimal Fieldsetid { get; set; }
        public string C1R050 { get; set; }
        public string C2R050 { get; set; }
        public string C3R050 { get; set; }
        public string C3aR050 { get; set; }
        public string C3bR050 { get; set; }
        public string C3cR050 { get; set; }
        public decimal? C4R050 { get; set; }
        public decimal? C5R050 { get; set; }
        public decimal? C6R050 { get; set; }
        public decimal? C7R050 { get; set; }
        public decimal? C8R050 { get; set; }
        public decimal? C9R050 { get; set; }
        public decimal? C10R050 { get; set; }
        public decimal? C11R050 { get; set; }
        public decimal? C12R050 { get; set; }
        public decimal? C13R050 { get; set; }

        public virtual DcArpReport0503191 Doc { get; set; }
    }
}
