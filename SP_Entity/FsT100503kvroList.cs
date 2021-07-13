using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class FsT100503kvroList
    {
        public decimal? Docid { get; set; }
        public decimal? Tablerownum { get; set; }
        public decimal Fieldsetid { get; set; }
        public string C0R10 { get; set; }
        public string C1R10 { get; set; }
        public string C2R10 { get; set; }
        public string C2bR10 { get; set; }
        public decimal? C3R10 { get; set; }
        public bool? FlAuto { get; set; }
        public string ArithExpr { get; set; }
        public bool? FlSubrow { get; set; }
        public string Subrownm { get; set; }
        public string MarkerR10 { get; set; }

        public virtual DcArpReport0503kvro Doc { get; set; }
    }
}
