using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class DcReport0503762
    {
        public DcReport0503762()
        {
            FsInfores0503762List = new HashSet<FsInfores0503762List>();
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
        public decimal? ResultsC5S2New { get; set; }
        public decimal? ResultsC7S2New { get; set; }
        public string Ord { get; set; }
        public DateTime? Dateminusday { get; set; }
        public decimal? Currentyear { get; set; }

        public virtual ICollection<FsInfores0503762List> FsInfores0503762List { get; set; }
    }
}
