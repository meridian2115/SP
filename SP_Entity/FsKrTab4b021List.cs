using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class FsKrTab4b021List
    {
        public decimal? Docid { get; set; }
        public decimal? Tablerownum { get; set; }
        public decimal Fieldsetid { get; set; }
        public string C1R31 { get; set; }
        public string C2R31 { get; set; }
        public decimal? C3R31 { get; set; }
        public decimal? C4R31 { get; set; }
        public decimal? C5R31 { get; set; }
        public decimal? C6R31 { get; set; }
        public decimal? C7R31 { get; set; }
        public bool? FlAuto { get; set; }
        public string ArithExpr { get; set; }
        public bool? FlSubrow { get; set; }
        public string Subrownm { get; set; }
        public string C0R31 { get; set; }
        public string Page2 { get; set; }

        public virtual DcArpReport0507021 Doc { get; set; }
    }
}
