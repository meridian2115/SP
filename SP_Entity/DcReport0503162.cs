using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class DcReport0503162
    {
        public DcReport0503162()
        {
            FsExpense0503162List = new HashSet<FsExpense0503162List>();
        }

        public decimal Docid { get; set; }
        public decimal? Version { get; set; }
        public string SeLeader { get; set; }
        public string SeChiefAcc { get; set; }
        public string SeLeaderOfFes { get; set; }
        public string SePostLeader { get; set; }
        public string SePostChiefAcc { get; set; }
        public string SePostLeaderOf { get; set; }
        public string SeExecutor { get; set; }
        public string SePostExecutor { get; set; }
        public string SePhone { get; set; }
        public decimal? ResultsC5S2 { get; set; }
        public decimal? ResultsC7S2 { get; set; }
        public decimal? ResultsC5S3 { get; set; }
        public decimal? ResultsC7S3 { get; set; }
        public string Ord { get; set; }
        public DateTime? Currentyear { get; set; }
        public string ExecutorTel { get; set; }

        public virtual ICollection<FsExpense0503162List> FsExpense0503162List { get; set; }
    }
}
