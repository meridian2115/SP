using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class DcArpReport0531982
    {
        public DcArpReport0531982()
        {
            FsT10531982List = new HashSet<FsT10531982List>();
        }

        public decimal Docid { get; set; }
        public decimal? Version { get; set; }
        public decimal? S10531982S1Deb { get; set; }
        public decimal? S10531982S1Kred { get; set; }
        public string TitlePartOrd { get; set; }
        public string SePfnLeader { get; set; }
        public string SePfnChiefAcc { get; set; }
        public string SePfnLeaderOfFes { get; set; }
        public string SePfnPostLeader { get; set; }
        public string SePfnPostChiefAcc { get; set; }
        public string SePfnPostLeaderOf { get; set; }
        public string SePfnExecutor { get; set; }
        public string SePfnPostExecutor { get; set; }
        public string SePfnPhone { get; set; }
        public string SeTel { get; set; }

        public virtual ICollection<FsT10531982List> FsT10531982List { get; set; }
    }
}
