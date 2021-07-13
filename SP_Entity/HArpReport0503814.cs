using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class HArpReport0503814
    {
        public HArpReport0503814()
        {
            HfsInfoTabr1814List = new HashSet<HfsInfoTabr1814List>();
        }

        public decimal Id { get; set; }

        public virtual ICollection<HfsInfoTabr1814List> HfsInfoTabr1814List { get; set; }
    }
}
