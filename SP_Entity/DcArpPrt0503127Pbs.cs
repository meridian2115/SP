using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class DcArpPrt0503127Pbs
    {
        public DcArpPrt0503127Pbs()
        {
            FsRepVnk127pbsList = new HashSet<FsRepVnk127pbsList>();
            FsT1Vnk127pbsList = new HashSet<FsT1Vnk127pbsList>();
            FsT2Vnk127pbsList = new HashSet<FsT2Vnk127pbsList>();
            FsT3Vnk127pbsList = new HashSet<FsT3Vnk127pbsList>();
        }

        public decimal Docid { get; set; }
        public decimal? Version { get; set; }
        public string Ord { get; set; }
        public string SePfnLeader { get; set; }
        public string SePfnChiefAcc { get; set; }
        public string SePfnLeaderOfFes { get; set; }
        public string SePfnPostLeader { get; set; }
        public string SePfnPostChiefAcc { get; set; }
        public string SePfnPostLeaderOf { get; set; }
        public string SePfnExecutor { get; set; }
        public string SePfnPostExecutor { get; set; }
        public string SePfnPhone { get; set; }
        public DateTime? PrintDate { get; set; }
        public string Unsealed { get; set; }
        public DateTime? Logid { get; set; }
        public string PrCodereportform { get; set; }

        public virtual ICollection<FsRepVnk127pbsList> FsRepVnk127pbsList { get; set; }
        public virtual ICollection<FsT1Vnk127pbsList> FsT1Vnk127pbsList { get; set; }
        public virtual ICollection<FsT2Vnk127pbsList> FsT2Vnk127pbsList { get; set; }
        public virtual ICollection<FsT3Vnk127pbsList> FsT3Vnk127pbsList { get; set; }
    }
}
