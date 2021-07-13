using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class FsBeExpense164List
    {
        public decimal? Docid { get; set; }
        public decimal? Tablerownum { get; set; }
        public decimal Fieldsetid { get; set; }
        public string C2R2001 { get; set; }
        public string C1R2001 { get; set; }
        public string C1aR2001 { get; set; }
        public string C1bR2001 { get; set; }
        public string C1cR2001 { get; set; }
        public string C1dR2001 { get; set; }
        public string C1eR2001 { get; set; }
        public decimal? C3R2001 { get; set; }
        public decimal? C4R2001 { get; set; }
        public decimal? C5R2001 { get; set; }
        public decimal? C6R2001 { get; set; }
        public string C7R2001 { get; set; }
        public string C7aR2001 { get; set; }
        public string C8R2001 { get; set; }
        public decimal? C4R2001N { get; set; }
        public string Cdalt200 { get; set; }
        public string Nmsubjreport200 { get; set; }
        public string NumString4 { get; set; }

        public virtual DcReport0503164 Doc { get; set; }
    }
}
