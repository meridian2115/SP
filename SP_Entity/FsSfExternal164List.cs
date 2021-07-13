using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class FsSfExternal164List
    {
        public decimal? Docid { get; set; }
        public decimal? Tablerownum { get; set; }
        public decimal Fieldsetid { get; set; }
        public string C2R6201 { get; set; }
        public string C1R6201 { get; set; }
        public string C1aR62011 { get; set; }
        public string C1bR62012 { get; set; }
        public decimal? C3R6201 { get; set; }
        public decimal? C4R6201 { get; set; }
        public decimal? C5R6201 { get; set; }
        public decimal? C6R6201 { get; set; }
        public string C7R6201 { get; set; }
        public string C7aR6201 { get; set; }
        public string C8R6201 { get; set; }
        public string C1cR62011 { get; set; }
        public decimal? C4R6201N { get; set; }
        public string Cdalt620 { get; set; }
        public string Nmsubjreport620 { get; set; }
        public string NumString3 { get; set; }

        public virtual DcReport0503164 Doc { get; set; }
    }
}
