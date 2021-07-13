using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class FsS4T40503160List
    {
        public decimal? Docid { get; set; }
        public decimal? Tablerownum { get; set; }
        public decimal Fieldsetid { get; set; }
        public string T4C1R1 { get; set; }
        public string T4C2R1 { get; set; }
        public string C2R11b { get; set; }
        public string C2R11c { get; set; }
        public string T4C3R1 { get; set; }
        public string T4C4R1 { get; set; }
        public string T4S { get; set; }
        public string T4C3R2 { get; set; }
        public string T4C4R2 { get; set; }

        public virtual DcReport0503160T4 Doc { get; set; }
    }
}
