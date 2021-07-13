using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class HSetsOfReporting
    {
        public HSetsOfReporting()
        {
            HfsRepFormsList = new HashSet<HfsRepFormsList>();
        }

        public decimal Id { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public string TypeRepPeriod { get; set; }
        public string Note { get; set; }
        public string GlavaBk { get; set; }
        public string BtCodeOfBudget { get; set; }
        public string BtNameOfBudget { get; set; }
        public string BtCodeOfType { get; set; }

        public virtual ICollection<HfsRepFormsList> HfsRepFormsList { get; set; }
    }
}
