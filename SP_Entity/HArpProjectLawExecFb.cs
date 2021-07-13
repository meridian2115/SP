using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class HArpProjectLawExecFb
    {
        public HArpProjectLawExecFb()
        {
            HfsPlefbSec3List = new HashSet<HfsPlefbSec3List>();
            HfsPlefbSec4List = new HashSet<HfsPlefbSec4List>();
            HfsPlefbSec5List = new HashSet<HfsPlefbSec5List>();
        }

        public decimal Id { get; set; }
        public string Surrogat { get; set; }

        public virtual ICollection<HfsPlefbSec3List> HfsPlefbSec3List { get; set; }
        public virtual ICollection<HfsPlefbSec4List> HfsPlefbSec4List { get; set; }
        public virtual ICollection<HfsPlefbSec5List> HfsPlefbSec5List { get; set; }
    }
}
