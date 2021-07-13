using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class HArpReport0503372
    {
        public HArpReport0503372()
        {
            HfsT10503372List = new HashSet<HfsT10503372List>();
            HfsT20503372List = new HashSet<HfsT20503372List>();
            HfsT30503372List = new HashSet<HfsT30503372List>();
            HfsT40503372List = new HashSet<HfsT40503372List>();
        }

        public decimal Id { get; set; }
        public decimal? C2R01 { get; set; }
        public decimal? C3R01 { get; set; }
        public decimal? C2R02 { get; set; }
        public decimal? C3R02 { get; set; }
        public decimal? C5R03 { get; set; }
        public decimal? C6R03 { get; set; }
        public decimal? C3R04 { get; set; }
        public decimal? C4R04 { get; set; }

        public virtual ICollection<HfsT10503372List> HfsT10503372List { get; set; }
        public virtual ICollection<HfsT20503372List> HfsT20503372List { get; set; }
        public virtual ICollection<HfsT30503372List> HfsT30503372List { get; set; }
        public virtual ICollection<HfsT40503372List> HfsT40503372List { get; set; }
    }
}
