using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class HArpReport0503811
    {
        public HArpReport0503811()
        {
            HfsT10503811List = new HashSet<HfsT10503811List>();
            HfsT20503811List = new HashSet<HfsT20503811List>();
            HfsT30503811List = new HashSet<HfsT30503811List>();
        }

        public decimal Id { get; set; }
        public decimal? C8R01 { get; set; }
        public decimal? C7R02 { get; set; }
        public decimal? C8R02 { get; set; }
        public decimal? C9R02 { get; set; }
        public decimal? C10R02 { get; set; }
        public decimal? C11R02 { get; set; }
        public decimal? C8R03 { get; set; }

        public virtual ICollection<HfsT10503811List> HfsT10503811List { get; set; }
        public virtual ICollection<HfsT20503811List> HfsT20503811List { get; set; }
        public virtual ICollection<HfsT30503811List> HfsT30503811List { get; set; }
    }
}
