using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class FsCf2Vt800128npList
    {
        public decimal? Docid { get; set; }
        public decimal? Tablerownum { get; set; }
        public decimal Fieldsetid { get; set; }
        public decimal? C4R800 { get; set; }
        public decimal? C5R800 { get; set; }
        public decimal? C6R800 { get; set; }
        public decimal? C7R800 { get; set; }
        public decimal? C8R800 { get; set; }
        public decimal? C9R800 { get; set; }
        public decimal? C10R800 { get; set; }
        public decimal? C11R800 { get; set; }
        public decimal? C12R800 { get; set; }
        public decimal? C3R800 { get; set; }
        public string C2R800 { get; set; }
        public string C1R800 { get; set; }
        public string C3aR800 { get; set; }
        public string C3bR800 { get; set; }
        public string C3cR800 { get; set; }
        public string C3dR800 { get; set; }

        public virtual DcArpReport0503128Np Doc { get; set; }
    }
}
