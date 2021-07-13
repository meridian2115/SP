﻿using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class HfsBrRevenue184List
    {
        public decimal Fieldsetid { get; set; }
        public decimal? Tablerownum { get; set; }
        public decimal? Id { get; set; }
        public string C1R0102 { get; set; }
        public string C2R0102 { get; set; }
        public string C3R0102a { get; set; }
        public string C3R0102b { get; set; }
        public string C3R010All { get; set; }
        public decimal? C4R0102 { get; set; }

        public virtual HReport0503184 IdNavigation { get; set; }
    }
}
