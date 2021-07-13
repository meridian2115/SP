using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class FsAnalyticali169List
    {
        public decimal? Docid { get; set; }
        public decimal? Tablerownum { get; set; }
        public decimal Fieldsetid { get; set; }
        public string C1aR02030 { get; set; }
        public string C1bR02030 { get; set; }
        public string C1cR02030 { get; set; }
        public string C1dR02030 { get; set; }
        public string C1eR02030 { get; set; }
        public string C1All { get; set; }
        public decimal? C2R02030 { get; set; }
        public DateTime? C3R02030 { get; set; }
        public DateTime? C4R02030 { get; set; }
        public string C5R02030 { get; set; }
        public string C6R02030 { get; set; }
        public string C7R02030 { get; set; }
        public string C8R02030 { get; set; }
        public string Ac { get; set; }
        public string KbkType { get; set; }
        public string C1Rash1 { get; set; }
        public string C1Rash2 { get; set; }
        public string C1Rash3 { get; set; }

        public virtual DcReport0503169 Doc { get; set; }
    }
}
