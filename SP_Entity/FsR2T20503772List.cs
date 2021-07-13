using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class FsR2T20503772List
    {
        public decimal? Docid { get; set; }
        public decimal? Tablerownum { get; set; }
        public decimal Fieldsetid { get; set; }
        public string C1aR21 { get; set; }
        public string C1bR21 { get; set; }
        public string C1dR21 { get; set; }
        public string C1R21 { get; set; }
        public string C1kR21 { get; set; }
        public decimal? C2R21 { get; set; }
        public decimal? C3R21 { get; set; }
        public string C1R21All { get; set; }
        public string C1R21S { get; set; }
        public string Const00 { get; set; }
        public string C1b1R21 { get; set; }
        public string C1b2R21 { get; set; }
        public string C1b3R21 { get; set; }

        public virtual DcReport0503772 Doc { get; set; }
    }
}
