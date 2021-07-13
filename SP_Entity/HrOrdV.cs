﻿using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class HrOrdV
    {
        public int? Lvl { get; set; }
        public decimal? Id { get; set; }
        public decimal? IdParent { get; set; }
        public string Name { get; set; }
        public string Sort { get; set; }
    }
}