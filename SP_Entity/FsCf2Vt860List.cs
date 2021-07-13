using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class FsCf2Vt860List
    {
        public decimal? Docid { get; set; }
        public decimal? Tablerownum { get; set; }
        public decimal Fieldsetid { get; set; }
        public decimal? C4R860 { get; set; }
        public decimal? C5R860 { get; set; }
        public decimal? C6R860 { get; set; }
        public decimal? C7R860 { get; set; }
        public decimal? C8R860 { get; set; }
        public decimal? C9R860 { get; set; }
        public decimal? C10R860 { get; set; }
        public decimal? C11R860 { get; set; }
        public decimal? C12R860 { get; set; }
        public decimal? C3R860 { get; set; }
        public string C2R860 { get; set; }
        public string C1R860 { get; set; }

        public virtual DcArpReport0503128 Doc { get; set; }
    }
}
