using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class HArpReport0503773D
    {
        public HArpReport0503773D()
        {
            HfsTab0503773D1List = new HashSet<HfsTab0503773D1List>();
            HfsTab0503773D2List = new HashSet<HfsTab0503773D2List>();
        }

        public decimal Id { get; set; }

        public virtual ICollection<HfsTab0503773D1List> HfsTab0503773D1List { get; set; }
        public virtual ICollection<HfsTab0503773D2List> HfsTab0503773D2List { get; set; }
    }
}
