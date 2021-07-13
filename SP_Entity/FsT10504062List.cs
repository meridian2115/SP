using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class FsT10504062List
    {
        public decimal? Docid { get; set; }
        public decimal? Tablerownum { get; set; }
        public decimal Fieldsetid { get; set; }
        public string S1D1Account { get; set; }
        public string S117 { get; set; }
        public string S11 { get; set; }
        public string S15 { get; set; }
        public string S13 { get; set; }
        public string S1Full { get; set; }
        public decimal? S1D2LboYear { get; set; }
        public decimal? S1D3LboMonth { get; set; }
        public string S1D4Comment { get; set; }

        public virtual DcArpFah0504062 Doc { get; set; }
    }
}
