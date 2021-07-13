using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class FsR47732021T040773List
    {
        public decimal Fieldsetid { get; set; }
        public decimal? Tablerownum { get; set; }
        public decimal? Docid { get; set; }
        public string S4 { get; set; }
        public string C2R040 { get; set; }
        public decimal? C4R040 { get; set; }
        public decimal? C5R040 { get; set; }
        public decimal? C6R040 { get; set; }
        public decimal? C7R040 { get; set; }
        public decimal? C8R040 { get; set; }
        public decimal? C9R040 { get; set; }
        public decimal? C10R040 { get; set; }
        public decimal? C11R040 { get; set; }

        public virtual DcArpReport05037732019 Doc { get; set; }
    }
}
