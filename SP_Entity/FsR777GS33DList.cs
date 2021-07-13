using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class FsR777GS33DList
    {
        public decimal Fieldsetid { get; set; }
        public decimal? Tablerownum { get; set; }
        public decimal? Docid { get; set; }
        public string GS33DC1 { get; set; }
        public decimal? GS33DC2 { get; set; }
        public decimal? GS33DC3 { get; set; }
        public decimal? GS33DC4 { get; set; }
        public string GS33DC5 { get; set; }

        public virtual DcVlsReport0531777 Doc { get; set; }
    }
}
