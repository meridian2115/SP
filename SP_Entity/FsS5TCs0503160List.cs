using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class FsS5TCs0503160List
    {
        public decimal? Docid { get; set; }
        public decimal? Tablerownum { get; set; }
        public decimal Fieldsetid { get; set; }
        public string CsC1R1 { get; set; }
        public string CsC2R1 { get; set; }
        public string CsC3R1 { get; set; }
        public string TcsS { get; set; }

        public virtual DcReport0503160T5 Doc { get; set; }
    }
}
