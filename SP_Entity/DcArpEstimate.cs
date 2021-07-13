using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class DcArpEstimate
    {
        public DcArpEstimate()
        {
            FsBelboList = new HashSet<FsBelboList>();
        }

        public decimal Docid { get; set; }
        public decimal? Version { get; set; }
        public string DocNumber { get; set; }
        public string InstCode { get; set; }
        public string InstName { get; set; }
        public string ChapterCode { get; set; }
        public string BudgetCode { get; set; }
        public string RepPeriod { get; set; }
        public DateTime? RepDate { get; set; }
        public string TypeRepPeriod { get; set; }
        public decimal? TotalSumAll { get; set; }
        public string CodeForm { get; set; }
        public string InstNameGrbs { get; set; }
        public string InstNameRbs { get; set; }
        public string TypeRbsGrbs { get; set; }
        public string Ord { get; set; }
        public string PfnLeader { get; set; }
        public string PfnChiefAcc { get; set; }
        public string PfnLeaderOfFes { get; set; }
        public string PfnPostLeader { get; set; }
        public string PfnPostChiefAcc { get; set; }
        public string PfnPostLeaderOf { get; set; }
        public string PfnExecutor { get; set; }
        public string PfnPostExecutor { get; set; }
        public string PfnPhone { get; set; }

        public virtual ICollection<FsBelboList> FsBelboList { get; set; }
    }
}
