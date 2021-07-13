using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class FsR777GS23DList
    {
        public decimal Fieldsetid { get; set; }
        public decimal? Tablerownum { get; set; }
        public decimal? Docid { get; set; }
        public string GS23DC1 { get; set; }
        public string GS23DC2 { get; set; }
        public decimal? GS23DC3 { get; set; }
        public decimal? GS23DC4 { get; set; }
        public decimal? GS23DC5 { get; set; }
        public string GS23DC6 { get; set; }

        public virtual DcVlsReport0531777 Doc { get; set; }
    }
}
