using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class HArpReport0507021
    {
        public HArpReport0507021()
        {
            HfsBeTabr2021List = new HashSet<HfsBeTabr2021List>();
            HfsBrTabr1021List = new HashSet<HfsBrTabr1021List>();
            HfsSfTabr3a021List = new HashSet<HfsSfTabr3a021List>();
            HfsSfTabr3b021List = new HashSet<HfsSfTabr3b021List>();
            HfsSfTabr3c021List = new HashSet<HfsSfTabr3c021List>();
            HfsSfTabr3d021List = new HashSet<HfsSfTabr3d021List>();
        }

        public decimal Id { get; set; }
        public string SfC3bR700 { get; set; }
        public string SfC3bR7001 { get; set; }
        public string SfC3bR7002 { get; set; }
        public string SfC3bR710 { get; set; }
        public string SfC3bR720 { get; set; }

        public virtual ICollection<HfsBeTabr2021List> HfsBeTabr2021List { get; set; }
        public virtual ICollection<HfsBrTabr1021List> HfsBrTabr1021List { get; set; }
        public virtual ICollection<HfsSfTabr3a021List> HfsSfTabr3a021List { get; set; }
        public virtual ICollection<HfsSfTabr3b021List> HfsSfTabr3b021List { get; set; }
        public virtual ICollection<HfsSfTabr3c021List> HfsSfTabr3c021List { get; set; }
        public virtual ICollection<HfsSfTabr3d021List> HfsSfTabr3d021List { get; set; }
    }
}
