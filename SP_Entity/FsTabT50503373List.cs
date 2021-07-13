using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class FsTabT50503373List
    {
        public decimal? Docid { get; set; }
        public decimal? Tablerownum { get; set; }
        public decimal Fieldsetid { get; set; }
        public string C0R5 { get; set; }
        public string C1R5 { get; set; }
        public decimal? C2R5 { get; set; }
        public string C3R5 { get; set; }
        public string C4R5 { get; set; }
        public string C5R5 { get; set; }
        public string C6R5 { get; set; }
        public string C7R5 { get; set; }
        public string C8R5 { get; set; }
        public bool? FlAuto { get; set; }
        public string ArithExpr { get; set; }
        public bool? FlSubrow { get; set; }
        public string Subrownm { get; set; }
        public string Kvd { get; set; }
        public string Acc { get; set; }
        public string Kosgu { get; set; }

        public virtual DcArpReport0503373 Doc { get; set; }
    }
}
