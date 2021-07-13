﻿using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class HfsInfoDebndem230List
    {
        public decimal Fieldsetid { get; set; }
        public decimal? Tablerownum { get; set; }
        public decimal? Id { get; set; }
        public string C3R2001 { get; set; }
        public decimal? C4R2001 { get; set; }
        public decimal? C5R2001 { get; set; }
        public string Tabcounter6 { get; set; }

        public virtual HReport0503230 IdNavigation { get; set; }
    }
}
