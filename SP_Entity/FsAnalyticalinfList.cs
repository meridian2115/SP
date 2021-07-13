using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class FsAnalyticalinfList
    {
        public decimal? Docid { get; set; }
        public decimal? Tablerownum { get; set; }
        public decimal Fieldsetid { get; set; }
        public string C1aR02030 { get; set; }
        public string C1bR02030 { get; set; }
        public string C1cR02030 { get; set; }
        public string C1dR01030 { get; set; }
        public string C1eR01030 { get; set; }
        public decimal? C2R02030 { get; set; }
        public string C4R02030 { get; set; }
        public string C5R02030 { get; set; }
        public string C6R02030 { get; set; }
        public string C1R02All { get; set; }
        public string C7R02030 { get; set; }
        public DateTime? C3R02030 { get; set; }
        public DateTime? C8R02030 { get; set; }
        public string Ac { get; set; }
        public string KbkType { get; set; }
        public string Section { get; set; }
        public string Target { get; set; }
        public string Codetype { get; set; }

        public virtual DcReport0503769 Doc { get; set; }
    }
}
