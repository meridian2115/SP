using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class HArpReport05037302019
    {
        public HArpReport05037302019()
        {
            HfsBa730Ba730List = new HashSet<HfsBa730Ba730List>();
            HfsBa730T040730List = new HashSet<HfsBa730T040730List>();
            HfsBa730T200730List = new HashSet<HfsBa730T200730List>();
        }

        public decimal Id { get; set; }
        public string Countline040 { get; set; }
        public string Countline200 { get; set; }

        public virtual ICollection<HfsBa730Ba730List> HfsBa730Ba730List { get; set; }
        public virtual ICollection<HfsBa730T040730List> HfsBa730T040730List { get; set; }
        public virtual ICollection<HfsBa730T200730List> HfsBa730T200730List { get; set; }
    }
}
