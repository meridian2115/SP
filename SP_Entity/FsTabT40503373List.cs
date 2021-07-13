using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class FsTabT40503373List
    {
        public decimal? Docid { get; set; }
        public decimal? Tablerownum { get; set; }
        public decimal Fieldsetid { get; set; }
        public string C0R4 { get; set; }
        public string C1R4 { get; set; }
        public string C2R4 { get; set; }
        public decimal? C3R4 { get; set; }
        public decimal? C4R4 { get; set; }
        public decimal? C5R4 { get; set; }
        public string C6R4 { get; set; }
        public string C7R4 { get; set; }
        public string C8R4 { get; set; }
        public bool? FlAuto { get; set; }
        public string ArithExpr { get; set; }
        public bool? FlSubrow { get; set; }
        public string Subrownm { get; set; }

        public virtual DcArpReport0503373 Doc { get; set; }
    }
}
