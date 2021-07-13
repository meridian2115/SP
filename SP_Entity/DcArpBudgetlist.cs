using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class DcArpBudgetlist
    {
        public DcArpBudgetlist()
        {
            FsBeExpAsList = new HashSet<FsBeExpAsList>();
            FsBeExpLboList = new HashSet<FsBeExpLboList>();
            FsIfdbIfdbList = new HashSet<FsIfdbIfdbList>();
        }

        public decimal Docid { get; set; }
        public decimal? Version { get; set; }
        public string DocNumber { get; set; }
        public string InstCode { get; set; }
        public string InstName { get; set; }
        public string ChapterCode { get; set; }
        public string BudgetCode { get; set; }
        public string Budgetname { get; set; }
        public string RepPeriod { get; set; }
        public DateTime? RepDate { get; set; }
        public string TypeRepPeriod { get; set; }
        public decimal? BeTotalSumAll { get; set; }
        public decimal? BeTotalSumLimAll { get; set; }
        public decimal? IfdbTotalSumIfdb { get; set; }

        public virtual ICollection<FsBeExpAsList> FsBeExpAsList { get; set; }
        public virtual ICollection<FsBeExpLboList> FsBeExpLboList { get; set; }
        public virtual ICollection<FsIfdbIfdbList> FsIfdbIfdbList { get; set; }
    }
}
