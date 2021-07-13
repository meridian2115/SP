using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class FsFpFpIncList
    {
        public decimal? Docid { get; set; }
        public decimal? Tablerownum { get; set; }
        public decimal Fieldsetid { get; set; }
        public string C1 { get; set; }
        public string C2 { get; set; }
        public decimal? C3 { get; set; }
        public decimal? C4 { get; set; }
        public decimal? C5 { get; set; }
        public decimal? C6 { get; set; }
        public decimal? C7 { get; set; }
        public decimal? C8 { get; set; }
        public decimal? C9 { get; set; }
        public decimal? C10 { get; set; }
        public decimal? C11 { get; set; }
        public decimal? C12 { get; set; }

        public virtual DcDbdLawBaSpr Doc { get; set; }
    }
}
