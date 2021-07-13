using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class FsS3T30503160List
    {
        public decimal? Docid { get; set; }
        public decimal? Tablerownum { get; set; }
        public decimal Fieldsetid { get; set; }
        public string T3C1R1 { get; set; }
        public string T3C2R1 { get; set; }
        public string T3C3R1 { get; set; }
        public string T3S { get; set; }
        public string T3C1R2 { get; set; }
        public string T3C2R2 { get; set; }
        public string T3C3R2 { get; set; }

        public virtual DcReport0503160T3 Doc { get; set; }
    }
}
