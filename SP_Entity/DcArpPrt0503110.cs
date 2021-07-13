using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class DcArpPrt0503110
    {
        public DcArpPrt0503110()
        {
            FsRepVnk110List = new HashSet<FsRepVnk110List>();
            FsT01Vnk110List = new HashSet<FsT01Vnk110List>();
            FsT02Vnk110List = new HashSet<FsT02Vnk110List>();
            FsT03Vnk110List = new HashSet<FsT03Vnk110List>();
            FsT04Vnk110List = new HashSet<FsT04Vnk110List>();
            FsT05Vnk110List = new HashSet<FsT05Vnk110List>();
            FsT06Vnk110List = new HashSet<FsT06Vnk110List>();
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

        public virtual ICollection<FsRepVnk110List> FsRepVnk110List { get; set; }
        public virtual ICollection<FsT01Vnk110List> FsT01Vnk110List { get; set; }
        public virtual ICollection<FsT02Vnk110List> FsT02Vnk110List { get; set; }
        public virtual ICollection<FsT03Vnk110List> FsT03Vnk110List { get; set; }
        public virtual ICollection<FsT04Vnk110List> FsT04Vnk110List { get; set; }
        public virtual ICollection<FsT05Vnk110List> FsT05Vnk110List { get; set; }
        public virtual ICollection<FsT06Vnk110List> FsT06Vnk110List { get; set; }
    }
}
