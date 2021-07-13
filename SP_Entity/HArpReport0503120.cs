using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class HArpReport0503120
    {
        public HArpReport0503120()
        {
            HfsBa19Ba120List = new HashSet<HfsBa19Ba120List>();
            HfsBa19T040120List = new HashSet<HfsBa19T040120List>();
            HfsBa19T200120List = new HashSet<HfsBa19T200120List>();
            HfsBaT0100503120List = new HashSet<HfsBaT0100503120List>();
            HfsBaT0200503120List = new HashSet<HfsBaT0200503120List>();
            HfsBaT0300503120List = new HashSet<HfsBaT0300503120List>();
            HfsBaT0400503120List = new HashSet<HfsBaT0400503120List>();
            HfsBaT0500503120List = new HashSet<HfsBaT0500503120List>();
            HfsBaT1200503120List = new HashSet<HfsBaT1200503120List>();
            HfsBaT1900503120List = new HashSet<HfsBaT1900503120List>();
            HfsBaT2000503120List = new HashSet<HfsBaT2000503120List>();
            HfsBaT2100503120List = new HashSet<HfsBaT2100503120List>();
            HfsBaT2300503120List = new HashSet<HfsBaT2300503120List>();
            HfsBaTab0503120baList = new HashSet<HfsBaTab0503120baList>();
        }

        public decimal Id { get; set; }
        public string Surrogat { get; set; }
        public string BaCountsum010 { get; set; }
        public string BaCountsum020 { get; set; }
        public string BaCountsum030 { get; set; }
        public string BaCountsum040 { get; set; }
        public string BaCountsum050 { get; set; }
        public string BaCountsum120 { get; set; }
        public string BaCountsum190 { get; set; }
        public string BaCountsum200 { get; set; }
        public string BaCountsum210 { get; set; }
        public string BaCountsum230 { get; set; }

        public virtual ICollection<HfsBa19Ba120List> HfsBa19Ba120List { get; set; }
        public virtual ICollection<HfsBa19T040120List> HfsBa19T040120List { get; set; }
        public virtual ICollection<HfsBa19T200120List> HfsBa19T200120List { get; set; }
        public virtual ICollection<HfsBaT0100503120List> HfsBaT0100503120List { get; set; }
        public virtual ICollection<HfsBaT0200503120List> HfsBaT0200503120List { get; set; }
        public virtual ICollection<HfsBaT0300503120List> HfsBaT0300503120List { get; set; }
        public virtual ICollection<HfsBaT0400503120List> HfsBaT0400503120List { get; set; }
        public virtual ICollection<HfsBaT0500503120List> HfsBaT0500503120List { get; set; }
        public virtual ICollection<HfsBaT1200503120List> HfsBaT1200503120List { get; set; }
        public virtual ICollection<HfsBaT1900503120List> HfsBaT1900503120List { get; set; }
        public virtual ICollection<HfsBaT2000503120List> HfsBaT2000503120List { get; set; }
        public virtual ICollection<HfsBaT2100503120List> HfsBaT2100503120List { get; set; }
        public virtual ICollection<HfsBaT2300503120List> HfsBaT2300503120List { get; set; }
        public virtual ICollection<HfsBaTab0503120baList> HfsBaTab0503120baList { get; set; }
    }
}
