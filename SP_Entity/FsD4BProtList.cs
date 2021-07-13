﻿using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class FsD4BProtList
    {
        public decimal Fieldsetid { get; set; }
        public decimal? Tablerownum { get; set; }
        public decimal? FsD4OnkSlListid { get; set; }
        public string Prot { get; set; }
        public DateTime? DProt { get; set; }

        public virtual FsD4OnkSlList FsD4OnkSlList { get; set; }
    }
}
