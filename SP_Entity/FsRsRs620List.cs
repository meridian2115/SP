using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class FsRsRs620List
    {
        public decimal? Docid { get; set; }
        public decimal? Tablerownum { get; set; }
        public decimal Fieldsetid { get; set; }
        public decimal? C4R6211 { get; set; }
        public decimal? C5R6211 { get; set; }
        public decimal? C6R6211 { get; set; }
        public decimal? C7R6211 { get; set; }
        public decimal? C8R6211 { get; set; }
        public decimal? C9R6211 { get; set; }
        public decimal? C10R6211 { get; set; }
        public string C1R621 { get; set; }
        public string C2R621 { get; set; }
        public string C3R621 { get; set; }

        public virtual DcArpReport0503737 Doc { get; set; }
    }
}
