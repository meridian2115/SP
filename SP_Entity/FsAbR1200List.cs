﻿using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class FsAbR1200List
    {
        public decimal? Docid { get; set; }
        public decimal? Tablerownum { get; set; }
        public decimal Fieldsetid { get; set; }
        public string C1R2001 { get; set; }
        public string C2R2001 { get; set; }
        public string C3R2001 { get; set; }
        public string C3nR2001 { get; set; }
        public string C4R2001 { get; set; }
        public string C4vR2001 { get; set; }
        public string C4nR2001 { get; set; }
        public string C45R2001 { get; set; }
        public string C5R2001 { get; set; }
        public string C5aR2001 { get; set; }
        public string C5bR2001 { get; set; }
        public string C5cR2001 { get; set; }
        public string C5dR2001 { get; set; }
        public string C5eR2001 { get; set; }
        public decimal? C6R2001 { get; set; }
        public decimal? C7R2001 { get; set; }
        public decimal? C8R2001 { get; set; }
        public decimal? C9R2001 { get; set; }
        public decimal? Num200 { get; set; }
        public string C5ncR2001 { get; set; }
        public string C5ndR2001 { get; set; }
        public string C5neR2001 { get; set; }
        public DateTime? RepDate200 { get; set; }
        public string PaCode { get; set; }

        public virtual DcArpReport0531342 Doc { get; set; }
    }
}
