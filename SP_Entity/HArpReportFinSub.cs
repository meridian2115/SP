using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class HArpReportFinSub
    {
        public HArpReportFinSub()
        {
            HfsFinSubTab1List = new HashSet<HfsFinSubTab1List>();
            HfsFinSubTab402List = new HashSet<HfsFinSubTab402List>();
            HfsFinSubTab502List = new HashSet<HfsFinSubTab502List>();
        }

        public decimal Id { get; set; }

        public virtual ICollection<HfsFinSubTab1List> HfsFinSubTab1List { get; set; }
        public virtual ICollection<HfsFinSubTab402List> HfsFinSubTab402List { get; set; }
        public virtual ICollection<HfsFinSubTab502List> HfsFinSubTab502List { get; set; }
    }
}
