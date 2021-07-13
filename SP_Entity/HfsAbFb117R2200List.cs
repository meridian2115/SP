﻿using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class HfsAbFb117R2200List
    {
        public decimal Fieldsetid { get; set; }
        public decimal? Tablerownum { get; set; }
        public decimal? Id { get; set; }
        public string C1R2001 { get; set; }
        public string C2R2001 { get; set; }
        public string C3R2001 { get; set; }
        public string C3aR2001 { get; set; }
        public string C3bR2001 { get; set; }
        public string C3cR2001 { get; set; }
        public string C3dR2001 { get; set; }
        public decimal? C4R2001 { get; set; }
        public decimal? C5R2001 { get; set; }
        public decimal? C6R2001 { get; set; }

        public virtual HReport0503117Fb IdNavigation { get; set; }
    }
}
