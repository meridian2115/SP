using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class HArpReport0503317
    {
        public HArpReport0503317()
        {
            HfsBeTabr2317List = new HashSet<HfsBeTabr2317List>();
            HfsBrTabr1317List = new HashSet<HfsBrTabr1317List>();
            HfsSfTab3a317List = new HashSet<HfsSfTab3a317List>();
            HfsSfTab3b317List = new HashSet<HfsSfTab3b317List>();
            HfsSfTab3c317List = new HashSet<HfsSfTab3c317List>();
            HfsSfTab3d317List = new HashSet<HfsSfTab3d317List>();
        }

        public decimal Id { get; set; }
        public string BrC3bR010 { get; set; }
        public string BeC3bR200 { get; set; }
        public string BeC3cR200 { get; set; }
        public string BeC3dR200 { get; set; }
        public string BeC3bR450 { get; set; }
        public string BeC3cR450 { get; set; }
        public string BeC3dR450 { get; set; }
        public string SfC3bR500 { get; set; }
        public string SfC3bR520 { get; set; }
        public string SfC3bR620 { get; set; }
        public string SfC3bR700 { get; set; }
        public string SfC3bR7001 { get; set; }
        public string SfC3bR7002 { get; set; }
        public string SfC3bR710 { get; set; }
        public string SfC3bR720 { get; set; }

        public virtual ICollection<HfsBeTabr2317List> HfsBeTabr2317List { get; set; }
        public virtual ICollection<HfsBrTabr1317List> HfsBrTabr1317List { get; set; }
        public virtual ICollection<HfsSfTab3a317List> HfsSfTab3a317List { get; set; }
        public virtual ICollection<HfsSfTab3b317List> HfsSfTab3b317List { get; set; }
        public virtual ICollection<HfsSfTab3c317List> HfsSfTab3c317List { get; set; }
        public virtual ICollection<HfsSfTab3d317List> HfsSfTab3d317List { get; set; }
    }
}
