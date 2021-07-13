using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class FsR777GS22DList
    {
        public decimal Fieldsetid { get; set; }
        public decimal? Tablerownum { get; set; }
        public decimal? Docid { get; set; }
        public string GS22DC1 { get; set; }
        public string GS22DC2 { get; set; }
        public decimal? GS22DC3 { get; set; }
        public decimal? GS22DC4 { get; set; }
        public decimal? GS22DC5 { get; set; }
        public string GS22DC6 { get; set; }

        public virtual DcVlsReport0531777 Doc { get; set; }
    }
}
