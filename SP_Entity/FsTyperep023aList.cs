using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class FsTyperep023aList
    {
        public decimal? Docid { get; set; }
        public decimal? Tablerownum { get; set; }
        public decimal Fieldsetid { get; set; }
        public bool? FlAuto { get; set; }
        public string ArithExpr { get; set; }
        public bool? FlSubrow { get; set; }
        public string Subrownm3 { get; set; }
        public string C0R3 { get; set; }
        public string C1R3 { get; set; }
        public string C2R3 { get; set; }
        public string C3R3 { get; set; }
        public decimal? C4R3 { get; set; }
        public decimal? C5R3 { get; set; }
        public decimal? C6R3 { get; set; }
        public decimal? C7R3 { get; set; }
        public decimal? C8R3 { get; set; }
        public string C9R3 { get; set; }
        public decimal? C91R3 { get; set; }
        public string Page3 { get; set; }
        public string Fieldx03 { get; set; }
        public string FontStyleRownm3 { get; set; }

        public virtual DcArpReport0507023 Doc { get; set; }
    }
}
