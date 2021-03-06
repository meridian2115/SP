using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class FsSfDecreaseList
    {
        public decimal? Docid { get; set; }
        public decimal? Tablerownum { get; set; }
        public decimal Fieldsetid { get; set; }
        public string C1R7201 { get; set; }
        public string C2R7201 { get; set; }
        public string C3R7201 { get; set; }
        public string C3aR7201 { get; set; }
        public string C3bR7201 { get; set; }
        public decimal? C4R7201 { get; set; }
        public decimal? C6R7201 { get; set; }
        public decimal? C7R7201 { get; set; }
        public decimal? C8R7201 { get; set; }
        public string Num720 { get; set; }
        public decimal? C48R7201 { get; set; }

        public virtual DcReport0503127 Doc { get; set; }
    }
}
