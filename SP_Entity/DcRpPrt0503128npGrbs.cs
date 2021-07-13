using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class DcRpPrt0503128npGrbs
    {
        public DcRpPrt0503128npGrbs()
        {
            FsRepVnk128npGrbsList = new HashSet<FsRepVnk128npGrbsList>();
            FsT01Vnk128npGrbsList = new HashSet<FsT01Vnk128npGrbsList>();
            FsT02Vnk128npGrbsList = new HashSet<FsT02Vnk128npGrbsList>();
            FsT03Vnk128npGrbsList = new HashSet<FsT03Vnk128npGrbsList>();
        }

        public decimal Docid { get; set; }
        public decimal? Version { get; set; }
        public DateTime? Logid { get; set; }
        public string PrCodereportform { get; set; }
        public DateTime? PrintDate { get; set; }
        public string Unsealed { get; set; }
        public string SePfnLeader { get; set; }
        public string SePfnChiefAcc { get; set; }
        public string SePfnLeaderOfFes { get; set; }
        public string SePfnPostLeader { get; set; }
        public string SePfnPostChiefAcc { get; set; }
        public string SePfnPostLeaderOf { get; set; }
        public string SePfnExecutor { get; set; }
        public string SePfnPostExecutor { get; set; }
        public string SePfnPhone { get; set; }

        public virtual ICollection<FsRepVnk128npGrbsList> FsRepVnk128npGrbsList { get; set; }
        public virtual ICollection<FsT01Vnk128npGrbsList> FsT01Vnk128npGrbsList { get; set; }
        public virtual ICollection<FsT02Vnk128npGrbsList> FsT02Vnk128npGrbsList { get; set; }
        public virtual ICollection<FsT03Vnk128npGrbsList> FsT03Vnk128npGrbsList { get; set; }
    }
}
