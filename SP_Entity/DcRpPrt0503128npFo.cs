using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class DcRpPrt0503128npFo
    {
        public DcRpPrt0503128npFo()
        {
            FsRepVnk1282List = new HashSet<FsRepVnk1282List>();
            FsT01Vnk128List = new HashSet<FsT01Vnk128List>();
        }

        public decimal Docid { get; set; }
        public decimal? Version { get; set; }
        public decimal? Logid { get; set; }
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

        public virtual ICollection<FsRepVnk1282List> FsRepVnk1282List { get; set; }
        public virtual ICollection<FsT01Vnk128List> FsT01Vnk128List { get; set; }
    }
}
