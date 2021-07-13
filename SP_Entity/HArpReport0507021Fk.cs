using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class HArpReport0507021Fk
    {
        public HArpReport0507021Fk()
        {
            HfsBe1T2021fkList = new HashSet<HfsBe1T2021fkList>();
            HfsBeTabr2021fkList = new HashSet<HfsBeTabr2021fkList>();
            HfsBedTabr2021fkList = new HashSet<HfsBedTabr2021fkList>();
            HfsBr1T1021fkList = new HashSet<HfsBr1T1021fkList>();
            HfsBrTabr1021fkList = new HashSet<HfsBrTabr1021fkList>();
            HfsBrdTabr1021fkList = new HashSet<HfsBrdTabr1021fkList>();
            HfsSf1T3021fkList = new HashSet<HfsSf1T3021fkList>();
            HfsSfTabr3021fkList = new HashSet<HfsSfTabr3021fkList>();
            HfsSfdTabr3021fkList = new HashSet<HfsSfdTabr3021fkList>();
        }

        public decimal Id { get; set; }

        public virtual ICollection<HfsBe1T2021fkList> HfsBe1T2021fkList { get; set; }
        public virtual ICollection<HfsBeTabr2021fkList> HfsBeTabr2021fkList { get; set; }
        public virtual ICollection<HfsBedTabr2021fkList> HfsBedTabr2021fkList { get; set; }
        public virtual ICollection<HfsBr1T1021fkList> HfsBr1T1021fkList { get; set; }
        public virtual ICollection<HfsBrTabr1021fkList> HfsBrTabr1021fkList { get; set; }
        public virtual ICollection<HfsBrdTabr1021fkList> HfsBrdTabr1021fkList { get; set; }
        public virtual ICollection<HfsSf1T3021fkList> HfsSf1T3021fkList { get; set; }
        public virtual ICollection<HfsSfTabr3021fkList> HfsSfTabr3021fkList { get; set; }
        public virtual ICollection<HfsSfdTabr3021fkList> HfsSfdTabr3021fkList { get; set; }
    }
}
