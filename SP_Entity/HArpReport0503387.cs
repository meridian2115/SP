using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class HArpReport0503387
    {
        public HArpReport0503387()
        {
            HfsT1387List = new HashSet<HfsT1387List>();
            HfsT2387List = new HashSet<HfsT2387List>();
        }

        public decimal Id { get; set; }

        public virtual ICollection<HfsT1387List> HfsT1387List { get; set; }
        public virtual ICollection<HfsT2387List> HfsT2387List { get; set; }
    }
}
