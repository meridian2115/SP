using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class HArpReport0503822
    {
        public HArpReport0503822()
        {
            HfsT10503822List = new HashSet<HfsT10503822List>();
        }

        public decimal Id { get; set; }
        public string Telephone { get; set; }
        public string Grif { get; set; }

        public virtual ICollection<HfsT10503822List> HfsT10503822List { get; set; }
    }
}
