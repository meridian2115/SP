﻿using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class FsR759GS31DList
    {
        public decimal? Docid { get; set; }
        public decimal? Tablerownum { get; set; }
        public decimal Fieldsetid { get; set; }
        public decimal? GS31BC2 { get; set; }
        public decimal? GS31BC3 { get; set; }
        public decimal? GS31BC4 { get; set; }
        public decimal? GS31BC5 { get; set; }
        public decimal? GS31BC6 { get; set; }
        public decimal? GS31BC7 { get; set; }
        public decimal? GS31BC8 { get; set; }
        public decimal? GS31EC2 { get; set; }
        public decimal? GS31EC3 { get; set; }
        public decimal? GS31EC4 { get; set; }
        public decimal? GS31EC5 { get; set; }
        public decimal? GS31EC6 { get; set; }
        public decimal? GS31EC7 { get; set; }
        public decimal? GS31EC8 { get; set; }

        public virtual DcVlsReport0531759 Doc { get; set; }
    }
}
