using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class FsRrRrasxodList
    {
        public decimal? Docid { get; set; }
        public decimal? Tablerownum { get; set; }
        public decimal Fieldsetid { get; set; }
        public string C1R2001R { get; set; }
        public string C2R2001R { get; set; }
        public string C3R2001R { get; set; }
        public decimal? C4R2001R { get; set; }
        public decimal? C5R2001R { get; set; }
        public decimal? C6R2001R { get; set; }
        public decimal? C7R2001R { get; set; }
        public decimal? C8R2001R { get; set; }
        public decimal? C9R2001R { get; set; }
        public decimal? C10R2001R { get; set; }
        public string Num2001R { get; set; }

        public virtual DcArpReport0503737 Doc { get; set; }
    }
}
