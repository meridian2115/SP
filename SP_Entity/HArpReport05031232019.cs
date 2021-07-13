using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class HArpReport05031232019
    {
        public HArpReport05031232019()
        {
            HfsC31In1232019List = new HashSet<HfsC31In1232019List>();
            HfsC31Out1232019List = new HashSet<HfsC31Out1232019List>();
        }

        public decimal Id { get; set; }
        public string C31C4aR810 { get; set; }
        public string C31C4bR810 { get; set; }
        public string C31C4aR820 { get; set; }
        public string C31C4bR820 { get; set; }

        public virtual ICollection<HfsC31In1232019List> HfsC31In1232019List { get; set; }
        public virtual ICollection<HfsC31Out1232019List> HfsC31Out1232019List { get; set; }
    }
}
