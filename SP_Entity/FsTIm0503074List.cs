using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class FsTIm0503074List
    {
        public decimal? Docid { get; set; }
        public decimal? Tablerownum { get; set; }
        public decimal Fieldsetid { get; set; }
        public string C0R1 { get; set; }
        public string C1R010 { get; set; }
        public string C2R010 { get; set; }
        public decimal? C3R010 { get; set; }
        public decimal? C4R010 { get; set; }
        public decimal? C5R010 { get; set; }
        public decimal? C6R010 { get; set; }
        public decimal? C7R010 { get; set; }
        public decimal? C8R010 { get; set; }
        public bool? FlAuto { get; set; }
        public string ArithExpr { get; set; }
        public bool? FlSubrow { get; set; }
        public string Subrownm { get; set; }

        public virtual DcArpf0503296 Doc { get; set; }
    }
}
