using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class FsTabT20503373List
    {
        public decimal? Docid { get; set; }
        public decimal? Tablerownum { get; set; }
        public decimal Fieldsetid { get; set; }
        public string C0R2 { get; set; }
        public string C1R2 { get; set; }
        public string C2R2 { get; set; }
        public decimal? C3R2 { get; set; }
        public decimal? C4R2 { get; set; }
        public decimal? C5R2 { get; set; }
        public string C6R2 { get; set; }
        public string C7R2 { get; set; }
        public string C8R2 { get; set; }
        public bool? FlAuto { get; set; }
        public string ArithExpr { get; set; }
        public bool? FlSubrow { get; set; }
        public string Subrownm { get; set; }
        public string Page { get; set; }

        public virtual DcArpReport0503373 Doc { get; set; }
    }
}
