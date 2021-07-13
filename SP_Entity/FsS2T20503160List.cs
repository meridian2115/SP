using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class FsS2T20503160List
    {
        public decimal? Docid { get; set; }
        public decimal? Tablerownum { get; set; }
        public decimal Fieldsetid { get; set; }
        public string T2C1R1 { get; set; }
        public string T2C2R1 { get; set; }
        public string T2C3R1 { get; set; }
        public string T2C4R1 { get; set; }
        public string T2C5R1 { get; set; }
        public string T2S { get; set; }

        public virtual DcReport0503160T2 Doc { get; set; }
    }
}
