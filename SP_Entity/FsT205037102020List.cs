using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class FsT205037102020List
    {
        public decimal Fieldsetid { get; set; }
        public decimal? Tablerownum { get; set; }
        public decimal? Docid { get; set; }
        public string C1R022020 { get; set; }
        public string C1aR022020 { get; set; }
        public string C1bR022020 { get; set; }
        public string C1cR022020 { get; set; }
        public string C2R022020 { get; set; }
        public string C3R022020 { get; set; }
        public decimal? C4R022020 { get; set; }
        public decimal? C5R022020 { get; set; }
        public decimal? C6R022020 { get; set; }
        public decimal? C7R022020 { get; set; }

        public virtual DcArpReport0503710 Doc { get; set; }
    }
}
