using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class HArpStatpredotch
    {
        public HArpStatpredotch()
        {
            HfsT2StatList = new HashSet<HfsT2StatList>();
            HfsT3StatList = new HashSet<HfsT3StatList>();
        }

        public decimal Id { get; set; }
        public string PeriodTypeC { get; set; }
        public DateTime? ReportDateC { get; set; }
        public string NameOfEntityC { get; set; }

        public virtual ICollection<HfsT2StatList> HfsT2StatList { get; set; }
        public virtual ICollection<HfsT3StatList> HfsT3StatList { get; set; }
    }
}
