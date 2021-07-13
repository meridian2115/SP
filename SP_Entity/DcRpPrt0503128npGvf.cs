using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class DcRpPrt0503128npGvf
    {
        public DcRpPrt0503128npGvf()
        {
            FsRepVnk128npGvfList = new HashSet<FsRepVnk128npGvfList>();
            FsTVnk128npGvfList = new HashSet<FsTVnk128npGvfList>();
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

        public virtual ICollection<FsRepVnk128npGvfList> FsRepVnk128npGvfList { get; set; }
        public virtual ICollection<FsTVnk128npGvfList> FsTVnk128npGvfList { get; set; }
    }
}
