﻿using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class HArpFahSets
    {
        public HArpFahSets()
        {
            HfsRegistresList = new HashSet<HfsRegistresList>();
        }

        public decimal Id { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public string Note { get; set; }

        public virtual ICollection<HfsRegistresList> HfsRegistresList { get; set; }
    }
}
