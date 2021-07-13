using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class FsT10503130List
    {
        public decimal? Docid { get; set; }
        public decimal? Tablerownum { get; set; }
        public decimal Fieldsetid { get; set; }
        public string C1R1 { get; set; }
        public string C2R1 { get; set; }
        public decimal? C3R1 { get; set; }
        public decimal? C4R1 { get; set; }
        public decimal? C5R1 { get; set; }
        public decimal? C6R1 { get; set; }
        public decimal? C7R1 { get; set; }
        public decimal? C8R1 { get; set; }
        public bool? FlAuto1 { get; set; }
        public string ArithExpr1 { get; set; }
        public bool? FlSubrow1 { get; set; }
        public string Subrownm1 { get; set; }
        public string C0R1 { get; set; }
        public string C45R1 { get; set; }
        public string C46R1 { get; set; }
        public string Page { get; set; }

        public virtual DcArpReport0503130D Doc { get; set; }
    }
}
