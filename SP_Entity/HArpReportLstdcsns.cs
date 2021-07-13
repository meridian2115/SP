using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class HArpReportLstdcsns
    {
        public HArpReportLstdcsns()
        {
            HfsTabR1List = new HashSet<HfsTabR1List>();
            HfsTabR2List = new HashSet<HfsTabR2List>();
            HfsTabR3List = new HashSet<HfsTabR3List>();
        }

        public decimal Id { get; set; }

        public virtual ICollection<HfsTabR1List> HfsTabR1List { get; set; }
        public virtual ICollection<HfsTabR2List> HfsTabR2List { get; set; }
        public virtual ICollection<HfsTabR3List> HfsTabR3List { get; set; }
    }
}
