using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class FsCf2Vt850128npList
    {
        public decimal? Docid { get; set; }
        public decimal? Tablerownum { get; set; }
        public decimal Fieldsetid { get; set; }
        public decimal? C4R850 { get; set; }
        public decimal? C5R850 { get; set; }
        public decimal? C6R850 { get; set; }
        public decimal? C7R850 { get; set; }
        public decimal? C8R850 { get; set; }
        public decimal? C9R850 { get; set; }
        public decimal? C10R850 { get; set; }
        public decimal? C11R850 { get; set; }
        public decimal? C12R850 { get; set; }
        public string C3R850 { get; set; }
        public string C2R850 { get; set; }
        public string C1R850 { get; set; }
        public string C3aR850 { get; set; }
        public string C3bR850 { get; set; }
        public string C3cR850 { get; set; }
        public string C3dR850 { get; set; }

        public virtual DcArpReport0503128Np Doc { get; set; }
    }
}
