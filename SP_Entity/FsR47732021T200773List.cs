using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class FsR47732021T200773List
    {
        public decimal Fieldsetid { get; set; }
        public decimal? Tablerownum { get; set; }
        public decimal? Docid { get; set; }
        public string S8 { get; set; }
        public string C2R200 { get; set; }
        public decimal? C4R200 { get; set; }
        public decimal? C5R200 { get; set; }
        public decimal? C6R200 { get; set; }
        public decimal? C7R200 { get; set; }
        public decimal? C8R200 { get; set; }
        public decimal? C9R200 { get; set; }
        public decimal? C10R200 { get; set; }
        public decimal? C11R200 { get; set; }

        public virtual DcArpReport05037732019 Doc { get; set; }
    }
}
