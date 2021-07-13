using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class FsR759GS41DList
    {
        public decimal? Docid { get; set; }
        public decimal? Tablerownum { get; set; }
        public decimal Fieldsetid { get; set; }
        public decimal? GS41BC2 { get; set; }
        public decimal? GS41BC3 { get; set; }
        public decimal? GS41BC4 { get; set; }
        public decimal? GS41EC2 { get; set; }
        public decimal? GS41EC3 { get; set; }
        public decimal? GS41EC4 { get; set; }

        public virtual DcVlsReport0531759 Doc { get; set; }
    }
}
