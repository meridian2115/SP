using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class FsR759GS21DList
    {
        public decimal? Docid { get; set; }
        public decimal? Tablerownum { get; set; }
        public decimal Fieldsetid { get; set; }
        public decimal? GS21BC2 { get; set; }
        public decimal? GS21BC3 { get; set; }
        public decimal? GS21BC4 { get; set; }
        public decimal? GS21BC5 { get; set; }
        public decimal? GS21BC6 { get; set; }
        public decimal? GS21BC7 { get; set; }
        public decimal? GS21EC2 { get; set; }
        public decimal? GS21EC3 { get; set; }
        public decimal? GS21EC4 { get; set; }
        public decimal? GS21EC5 { get; set; }
        public decimal? GS21EC6 { get; set; }
        public decimal? GS21EC7 { get; set; }

        public virtual DcVlsReport0531759 Doc { get; set; }
    }
}
