using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class HArpReport0531341
    {
        public HArpReport0531341()
        {
            HfsPbs341List = new HashSet<HfsPbs341List>();
        }

        public decimal Id { get; set; }

        public virtual ICollection<HfsPbs341List> HfsPbs341List { get; set; }
    }
}
