using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class HArpReport0503074
    {
        public HArpReport0503074()
        {
            HfsATyperep074List = new HashSet<HfsATyperep074List>();
        }

        public decimal Id { get; set; }
        public string HrOktmo { get; set; }

        public virtual ICollection<HfsATyperep074List> HfsATyperep074List { get; set; }
    }
}
