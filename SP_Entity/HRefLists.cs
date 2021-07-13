using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class HRefLists
    {
        public HRefLists()
        {
            HfsValsList = new HashSet<HfsValsList>();
        }

        public decimal Id { get; set; }
        public string Listnm { get; set; }

        public virtual ICollection<HfsValsList> HfsValsList { get; set; }
    }
}
