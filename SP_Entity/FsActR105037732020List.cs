using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class FsActR105037732020List
    {
        public decimal Fieldsetid { get; set; }
        public decimal? Tablerownum { get; set; }
        public decimal? Docid { get; set; }
        public string C0R1 { get; set; }
        public string C1R1 { get; set; }
        public string C2R1 { get; set; }
        public decimal? C3R1 { get; set; }
        public decimal? C4R1 { get; set; }
        public decimal? C5R1 { get; set; }
        public decimal? C6R1 { get; set; }
        public decimal? C7R1 { get; set; }
        public decimal? C8R1 { get; set; }
        public decimal? C9R1 { get; set; }
        public string ArithExpr { get; set; }
        public string FontStyleRownm { get; set; }
        public bool? FlAuto { get; set; }
        public bool? FlSubrow { get; set; }
        public string Subrownm { get; set; }
        public string Page { get; set; }
        public decimal? C10R1 { get; set; }

        public virtual DcArpReport05037732019 Doc { get; set; }
    }
}
