using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class DcArpPrt0503779Au
    {
        public DcArpPrt0503779Au()
        {
            FsRepVnk779List = new HashSet<FsRepVnk779List>();
            FsT1Vnk779uList = new HashSet<FsT1Vnk779uList>();
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

        public virtual ICollection<FsRepVnk779List> FsRepVnk779List { get; set; }
        public virtual ICollection<FsT1Vnk779uList> FsT1Vnk779uList { get; set; }
    }
}
