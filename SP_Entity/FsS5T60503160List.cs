using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class FsS5T60503160List
    {
        public decimal? Docid { get; set; }
        public decimal? Tablerownum { get; set; }
        public decimal Fieldsetid { get; set; }
        public string T6C1R1 { get; set; }
        public string T6C2R1 { get; set; }
        public string T6C3R1 { get; set; }
        public string T6C4R1 { get; set; }
        public string T6C5R1 { get; set; }
        public string C5R11b { get; set; }
        public string C5R11c { get; set; }
        public decimal? T6C6R1 { get; set; }
        public string T6C7R1 { get; set; }
        public string T6S { get; set; }

        public virtual DcReport0503160T6 Doc { get; set; }
    }
}
