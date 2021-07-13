using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class FsT30503372List
    {
        public decimal? Docid { get; set; }
        public decimal? Tablerownum { get; set; }
        public decimal Fieldsetid { get; set; }
        public string C1R031 { get; set; }
        public string C1aR031 { get; set; }
        public string C1bR031 { get; set; }
        public string C1cR031 { get; set; }
        public string C1dR031 { get; set; }
        public string C2R031 { get; set; }
        public string C3R031 { get; set; }
        public DateTime? C4R031 { get; set; }
        public decimal? C5R031 { get; set; }
        public decimal? C6R031 { get; set; }
        public DateTime? C7R031 { get; set; }
        public string C8R031 { get; set; }
        public string C8aR031 { get; set; }
        public string C9R031 { get; set; }
        public string LncdR031 { get; set; }

        public virtual DcArpReport0503372 Doc { get; set; }
    }
}
