using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class FsR777GS34DList
    {
        public decimal Fieldsetid { get; set; }
        public decimal? Tablerownum { get; set; }
        public decimal? Docid { get; set; }
        public string GS34DC1 { get; set; }
        public decimal? GS34DC2 { get; set; }
        public decimal? GS34DC3 { get; set; }
        public decimal? GS34DC4 { get; set; }
        public string GS34DC5 { get; set; }

        public virtual DcVlsReport0531777 Doc { get; set; }
    }
}
