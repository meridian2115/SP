using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class DcArpFoVnk2
    {
        public DcArpFoVnk2()
        {
            FsT1FoVnk2List = new HashSet<FsT1FoVnk2List>();
        }

        public decimal Docid { get; set; }
        public decimal? Version { get; set; }
        public string SePfnLeader { get; set; }
        public string SePfnChiefAcc { get; set; }
        public string SePfnLeaderOfFes { get; set; }
        public string SePfnPostLeader { get; set; }
        public string SePfnPostChiefAcc { get; set; }
        public string SePfnPostLeaderOf { get; set; }
        public string SePfnExecutor { get; set; }
        public string SePfnPostExecutor { get; set; }
        public string SePfnPhone { get; set; }
        public DateTime? Logid { get; set; }
        public string Ord { get; set; }
        public DateTime? PrintDate { get; set; }
        public string Unsealed { get; set; }

        public virtual ICollection<FsT1FoVnk2List> FsT1FoVnk2List { get; set; }
    }
}
