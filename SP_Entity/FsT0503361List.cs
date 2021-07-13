using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class FsT0503361List
    {
        public decimal? Docid { get; set; }
        public decimal? Tablerownum { get; set; }
        public decimal Fieldsetid { get; set; }
        public string G1 { get; set; }
        public string G2 { get; set; }
        public decimal? G3 { get; set; }
        public decimal? G4 { get; set; }
        public string G5 { get; set; }
        public bool? FlAuto1 { get; set; }
        public string ArithExpr1 { get; set; }
        public bool? FlSubrow1 { get; set; }
        public string Subrownm1 { get; set; }
        public string C0R1 { get; set; }

        public virtual DcArpreport0503361 Doc { get; set; }
    }
}
