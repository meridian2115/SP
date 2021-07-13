﻿using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class FsT0503167List
    {
        public decimal? Docid { get; set; }
        public decimal? Tablerownum { get; set; }
        public decimal Fieldsetid { get; set; }
        public string C1R1 { get; set; }
        public string C2R1 { get; set; }
        public DateTime? C3R1 { get; set; }
        public string C4R1 { get; set; }
        public decimal? C5R1 { get; set; }
        public decimal? C6R1 { get; set; }
        public string RNum { get; set; }

        public virtual DcReport0503167 Doc { get; set; }
    }
}
