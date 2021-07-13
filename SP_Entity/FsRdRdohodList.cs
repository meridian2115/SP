using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class FsRdRdohodList
    {
        public decimal? Docid { get; set; }
        public decimal? Tablerownum { get; set; }
        public decimal Fieldsetid { get; set; }
        public string C1R0101D { get; set; }
        public string C2R0101D { get; set; }
        public string C3R0101D { get; set; }
        public decimal? C4R0101D { get; set; }
        public decimal? C5R0101D { get; set; }
        public decimal? C6R0101D { get; set; }
        public decimal? C7R0101D { get; set; }
        public decimal? C8R0101D { get; set; }
        public decimal? C9R0101D { get; set; }
        public decimal? C10R0101D { get; set; }
        public string Num010D { get; set; }

        public virtual DcArpReport0503737 Doc { get; set; }
    }
}
