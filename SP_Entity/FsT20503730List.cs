using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class FsT20503730List
    {
        public decimal? Docid { get; set; }
        public decimal? Tablerownum { get; set; }
        public decimal Fieldsetid { get; set; }
        public string C1R2 { get; set; }
        public string C2R2 { get; set; }
        public decimal? C3R2 { get; set; }
        public decimal? C4R2 { get; set; }
        public decimal? C5R2 { get; set; }
        public decimal? C6R2 { get; set; }
        public decimal? C7R2 { get; set; }
        public decimal? C8R2 { get; set; }
        public decimal? C9R2 { get; set; }
        public decimal? C10R2 { get; set; }
        public bool? FlAuto2 { get; set; }
        public string ArithExpr2 { get; set; }
        public bool? FlSubrow2 { get; set; }
        public string Subrownm2 { get; set; }
        public string C0R2 { get; set; }
        public string C45R2 { get; set; }
        public string C46R2 { get; set; }
        public string Page { get; set; }

        public virtual DcArpReport05037302019 Doc { get; set; }
    }
}
