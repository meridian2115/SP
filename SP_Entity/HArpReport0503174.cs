using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class HArpReport0503174
    {
        public HArpReport0503174()
        {
            HfsTab1T1List = new HashSet<HfsTab1T1List>();
            HfsTab1T2List = new HashSet<HfsTab1T2List>();
        }

        public decimal Id { get; set; }
        public decimal? Tab1C4R1 { get; set; }
        public decimal? Tab1C6R1 { get; set; }
        public decimal? Tab1C7R1 { get; set; }
        public decimal? Tab1C8R1 { get; set; }
        public decimal? Tab1C4R2 { get; set; }
        public decimal? Tab1C6R2 { get; set; }
        public decimal? Tab1C7R2 { get; set; }
        public decimal? Tab1C8R2 { get; set; }
        public decimal? Tab1C4R0 { get; set; }
        public decimal? Tab1C6R0 { get; set; }
        public decimal? Tab1C7R0 { get; set; }
        public decimal? Tab1C8R0 { get; set; }

        public virtual ICollection<HfsTab1T1List> HfsTab1T1List { get; set; }
        public virtual ICollection<HfsTab1T2List> HfsTab1T2List { get; set; }
    }
}
