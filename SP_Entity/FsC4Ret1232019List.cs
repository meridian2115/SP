﻿using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class FsC4Ret1232019List
    {
        public decimal? Docid { get; set; }
        public decimal? Tablerownum { get; set; }
        public decimal Fieldsetid { get; set; }
        public string Name9801 { get; set; }
        public string Kosgu9801 { get; set; }
        public string Cdsubsec9801 { get; set; }
        public string Kvr9801 { get; set; }
        public decimal? Sum9801 { get; set; }
        public string Strcode9801 { get; set; }

        public virtual DcArpReport05031232019 Doc { get; set; }
    }
}
