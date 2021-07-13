﻿using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class FsInfoFrst730List
    {
        public decimal? Docid { get; set; }
        public decimal? Tablerownum { get; set; }
        public decimal Fieldsetid { get; set; }
        public string Tabcounter030 { get; set; }
        public string C2R0301 { get; set; }
        public string C3R0301 { get; set; }
        public decimal? C4R0301 { get; set; }
        public decimal? C5R0301 { get; set; }
        public decimal? C51R0301 { get; set; }
        public decimal? C6R0301 { get; set; }
        public decimal? C7R0301 { get; set; }
        public decimal? C8R0301 { get; set; }
        public decimal? C81R0301 { get; set; }
        public decimal? C9R0301 { get; set; }

        public virtual DcArprep0503730 Doc { get; set; }
    }
}
