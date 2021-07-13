using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class FsRcTab173aDList
    {
        public decimal? Docid { get; set; }
        public decimal? Tablerownum { get; set; }
        public decimal Fieldsetid { get; set; }
        public string C1aR21 { get; set; }
        public string C1bR21 { get; set; }
        public decimal? C2R21 { get; set; }
        public string C3R21 { get; set; }
        public string C4R21 { get; set; }
        public string C5R21 { get; set; }
        public string C1cR21 { get; set; }
        public string C1bR2S { get; set; }
        public string C1bR2V { get; set; }

        public virtual DcArpReport0503173D Doc { get; set; }
    }
}
