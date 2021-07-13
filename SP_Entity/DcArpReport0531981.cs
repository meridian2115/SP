using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class DcArpReport0531981
    {
        public DcArpReport0531981()
        {
            FsT10531981List = new HashSet<FsT10531981List>();
            FsT20531981List = new HashSet<FsT20531981List>();
            FsT30531981List = new HashSet<FsT30531981List>();
        }

        public decimal Docid { get; set; }
        public decimal? Version { get; set; }
        public decimal? S10531981S1Deb { get; set; }
        public decimal? S10531981S1Kred { get; set; }
        public decimal? S20531981S2Deb { get; set; }
        public decimal? S20531981S2Kred { get; set; }
        public decimal? S30531981S3Deb { get; set; }
        public decimal? S30531981S3Kred { get; set; }
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

        public virtual ICollection<FsT10531981List> FsT10531981List { get; set; }
        public virtual ICollection<FsT20531981List> FsT20531981List { get; set; }
        public virtual ICollection<FsT30531981List> FsT30531981List { get; set; }
    }
}
