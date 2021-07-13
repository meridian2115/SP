using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class FsR1T10503772List
    {
        public decimal? Docid { get; set; }
        public decimal? Tablerownum { get; set; }
        public decimal Fieldsetid { get; set; }
        public string C1aR11 { get; set; }
        public string C1bR11 { get; set; }
        public string C1dR11 { get; set; }
        public decimal? C2R11 { get; set; }
        public decimal? C3R11 { get; set; }
        public string C1R11 { get; set; }
        public string C1kR11 { get; set; }
        public string C1R11All { get; set; }
        public string C1R11S { get; set; }
        public string Const00 { get; set; }
        public string C1b1R11 { get; set; }
        public string C1b2R11 { get; set; }
        public string C1b3R11 { get; set; }

        public virtual DcReport0503772 Doc { get; set; }
    }
}
