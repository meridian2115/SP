using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class FsT10503377List
    {
        public decimal? Docid { get; set; }
        public decimal? Tablerownum { get; set; }
        public decimal Fieldsetid { get; set; }
        public string C0R1 { get; set; }
        public string C1R1 { get; set; }
        public string C1aR1 { get; set; }
        public string C2R1 { get; set; }
        public decimal? C3R1 { get; set; }
        public string C4R1 { get; set; }
        public bool? FlAuto { get; set; }
        public string ArithExpr { get; set; }
        public bool? FlSubrow { get; set; }
        public string Subrownm { get; set; }
        public string Pageex { get; set; }
        public string FontStyleRownm { get; set; }

        public virtual DcArpReportForm0503377 Doc { get; set; }
    }
}
