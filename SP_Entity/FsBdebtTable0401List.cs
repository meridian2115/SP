﻿using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class FsBdebtTable0401List
    {
        public decimal? Docid { get; set; }
        public decimal? Tablerownum { get; set; }
        public decimal Fieldsetid { get; set; }
        public string C1R040 { get; set; }
        public string C2R040 { get; set; }
        public string C3R040 { get; set; }
        public decimal? C4R040 { get; set; }

        public virtual DcArpReport0503253 Doc { get; set; }
    }
}