using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class FsRsRsredList
    {
        public decimal? Docid { get; set; }
        public decimal? Tablerownum { get; set; }
        public decimal Fieldsetid { get; set; }
        public string C1R500 { get; set; }
        public string C2R500 { get; set; }
        public string C3R500 { get; set; }
        public decimal? C4R500 { get; set; }
        public decimal? C5R500 { get; set; }
        public decimal? C6R500 { get; set; }
        public decimal? C7R500 { get; set; }
        public decimal? C8R500 { get; set; }
        public decimal? C9R500 { get; set; }
        public decimal? C10R500 { get; set; }
        public string Num500 { get; set; }

        public virtual DcArpReport0503737 Doc { get; set; }
    }
}
