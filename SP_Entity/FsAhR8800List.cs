﻿using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class FsAhR8800List
    {
        public decimal? Docid { get; set; }
        public decimal? Tablerownum { get; set; }
        public decimal Fieldsetid { get; set; }
        public string C1R8001 { get; set; }
        public string C2R8001 { get; set; }
        public decimal? C3R8001 { get; set; }
        public decimal? C4R8001 { get; set; }

        public virtual DcReport0503117Fb Doc { get; set; }
    }
}
