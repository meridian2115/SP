using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class FsRvRoList
    {
        public decimal? Docid { get; set; }
        public decimal? Tablerownum { get; set; }
        public decimal Fieldsetid { get; set; }
        public decimal? C4R9111 { get; set; }
        public decimal? C5R9111 { get; set; }
        public decimal? C6R9111 { get; set; }
        public decimal? C7R9111 { get; set; }
        public decimal? C8R9111 { get; set; }
        public string C1R911 { get; set; }
        public string C2R911 { get; set; }
        public string C3R911 { get; set; }

        public virtual DcArpReport0503737 Doc { get; set; }
    }
}
