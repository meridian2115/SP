using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class FsT3061List
    {
        public decimal? Docid { get; set; }
        public decimal? Tablerownum { get; set; }
        public decimal Fieldsetid { get; set; }
        public string C0R3 { get; set; }
        public string C1R3 { get; set; }
        public string C2R3 { get; set; }
        public string C3R3 { get; set; }
        public decimal? C4R3 { get; set; }
        public string ArithExpr { get; set; }
        public string Subrownm { get; set; }
        public decimal? C5R3 { get; set; }
        public decimal? C6R3 { get; set; }
        public decimal? C7R31 { get; set; }
        public decimal? C8R31 { get; set; }
        public decimal? C9R3 { get; set; }
        public string C10R3 { get; set; }
        public string C11R3 { get; set; }
        public string C12R3 { get; set; }
        public decimal? C7R3 { get; set; }

        public virtual DcArpReport0507061 Doc { get; set; }
    }
}
