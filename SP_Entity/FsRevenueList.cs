using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class FsRevenueList
    {
        public decimal? Docid { get; set; }
        public decimal? Tablerownum { get; set; }
        public decimal Fieldsetid { get; set; }
        public string C1aR01030 { get; set; }
        public string C1bR01030 { get; set; }
        public string C1cR01030 { get; set; }
        public string C1dR01030 { get; set; }
        public string C1eR01030 { get; set; }
        public string C1R01All { get; set; }
        public decimal? C2R01030 { get; set; }
        public decimal? C3R01030 { get; set; }
        public decimal? C4R01030 { get; set; }
        public decimal? C5R01030 { get; set; }
        public decimal? C12R01030 { get; set; }
        public decimal? C13R01030 { get; set; }
        public decimal? C14R01030 { get; set; }
        public decimal? C6R01030 { get; set; }
        public decimal? C7R01030 { get; set; }
        public decimal? C8R01030 { get; set; }
        public decimal? C9R01030 { get; set; }
        public decimal? C10R01030 { get; set; }
        public decimal? C11R01030 { get; set; }
        public string Ac { get; set; }
        public string KbkType { get; set; }
        public string Section { get; set; }
        public string Target { get; set; }
        public string Codetype { get; set; }

        public virtual DcReport0503769 Doc { get; set; }
    }
}
