﻿using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class HfsS3T23175List
    {
        public decimal Fieldsetid { get; set; }
        public decimal? Tablerownum { get; set; }
        public decimal? Id { get; set; }
        public string C1aR1 { get; set; }
        public string C1bR1 { get; set; }
        public string C1cR1 { get; set; }
        public string C1dR1 { get; set; }
        public string C1eR1 { get; set; }
        public string C2R1 { get; set; }
        public decimal? C3R1 { get; set; }
        public decimal? C4R1 { get; set; }
        public DateTime? C5R2 { get; set; }
        public DateTime? C6R1 { get; set; }
        public string C7R1 { get; set; }
        public string C8R1 { get; set; }
        public string PlanAccR1 { get; set; }

        public virtual HReport0503175 IdNavigation { get; set; }
    }
}
