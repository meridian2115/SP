using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class HArpReport0521462
    {
        public HArpReport0521462()
        {
            HfsTab462List = new HashSet<HfsTab462List>();
        }

        public decimal Id { get; set; }
        public string System { get; set; }
        public string System1 { get; set; }

        public virtual ICollection<HfsTab462List> HfsTab462List { get; set; }
    }
}
