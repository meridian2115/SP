using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class HArpEstimate
    {
        public HArpEstimate()
        {
            HfsBelboList = new HashSet<HfsBelboList>();
        }

        public decimal Id { get; set; }
        public string DocNumber { get; set; }
        public string InstCode { get; set; }
        public string InstName { get; set; }
        public string ChapterCode { get; set; }
        public string BudgetCode { get; set; }
        public string RepPeriod { get; set; }
        public DateTime? RepDate { get; set; }
        public string TypeRepPeriod { get; set; }
        public decimal? TotalSumAll { get; set; }

        public virtual ICollection<HfsBelboList> HfsBelboList { get; set; }
    }
}
