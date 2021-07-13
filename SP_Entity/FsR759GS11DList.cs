using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class FsR759GS11DList
    {
        public decimal? Docid { get; set; }
        public decimal? Tablerownum { get; set; }
        public decimal Fieldsetid { get; set; }
        public decimal? GS11BC2 { get; set; }
        public decimal? GS11BC3 { get; set; }
        public decimal? GS11BC4 { get; set; }
        public decimal? GS11BC5 { get; set; }
        public decimal? GS11BC6 { get; set; }
        public decimal? GS11BC7 { get; set; }
        public decimal? GS11BC8 { get; set; }
        public decimal? GS11BC9 { get; set; }
        public decimal? GS11EC2 { get; set; }
        public decimal? GS11EC3 { get; set; }
        public decimal? GS11EC4 { get; set; }
        public decimal? GS11EC5 { get; set; }
        public decimal? GS11EC6 { get; set; }
        public decimal? GS11EC7 { get; set; }
        public decimal? GS11EC8 { get; set; }
        public decimal? GS11EC9 { get; set; }

        public virtual DcVlsReport0531759 Doc { get; set; }
    }
}
