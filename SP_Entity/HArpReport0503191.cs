using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class HArpReport0503191
    {
        public HArpReport0503191()
        {
            HfsBdebtTable05List = new HashSet<HfsBdebtTable05List>();
        }

        public decimal Id { get; set; }

        public virtual ICollection<HfsBdebtTable05List> HfsBdebtTable05List { get; set; }
    }
}
