using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class FsT90503kvroList
    {
        public decimal? Docid { get; set; }
        public decimal? Tablerownum { get; set; }
        public decimal Fieldsetid { get; set; }
        public string C0R9 { get; set; }
        public string C1R9 { get; set; }
        public string C2R9 { get; set; }
        public string C2bR9 { get; set; }
        public decimal? C3R9 { get; set; }
        public bool? FlAuto { get; set; }
        public string ArithExpr { get; set; }
        public bool? FlSubrow { get; set; }
        public string Subrownm { get; set; }
        public string MarkerR9 { get; set; }

        public virtual DcArpReport0503kvro Doc { get; set; }
    }
}
