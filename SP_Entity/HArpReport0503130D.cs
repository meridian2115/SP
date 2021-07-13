using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class HArpReport0503130D
    {
        public HArpReport0503130D()
        {
            HfsBa19Ba130List = new HashSet<HfsBa19Ba130List>();
            HfsBa19T040130List = new HashSet<HfsBa19T040130List>();
            HfsBa19T200130List = new HashSet<HfsBa19T200130List>();
            HfsBaT010List = new HashSet<HfsBaT010List>();
            HfsBaT050List = new HashSet<HfsBaT050List>();
            HfsBaT1120List = new HashSet<HfsBaT1120List>();
            HfsBaTab0503320baList = new HashSet<HfsBaTab0503320baList>();
        }

        public decimal Id { get; set; }

        public virtual ICollection<HfsBa19Ba130List> HfsBa19Ba130List { get; set; }
        public virtual ICollection<HfsBa19T040130List> HfsBa19T040130List { get; set; }
        public virtual ICollection<HfsBa19T200130List> HfsBa19T200130List { get; set; }
        public virtual ICollection<HfsBaT010List> HfsBaT010List { get; set; }
        public virtual ICollection<HfsBaT050List> HfsBaT050List { get; set; }
        public virtual ICollection<HfsBaT1120List> HfsBaT1120List { get; set; }
        public virtual ICollection<HfsBaTab0503320baList> HfsBaTab0503320baList { get; set; }
    }
}
