using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class DcArpPrt0503178bk
    {
        public DcArpPrt0503178bk()
        {
            FsRepVnk178List = new HashSet<FsRepVnk178List>();
            FsT01Vnk178List = new HashSet<FsT01Vnk178List>();
            FsT02Vnk178List = new HashSet<FsT02Vnk178List>();
            FsT03Vnk178List = new HashSet<FsT03Vnk178List>();
        }

        public decimal Docid { get; set; }
        public decimal? Version { get; set; }
        public string Surrogat { get; set; }
        public decimal? R1I2 { get; set; }
        public decimal? R1I3 { get; set; }
        public decimal? R1I4 { get; set; }
        public decimal? R1I5 { get; set; }
        public decimal? R1I6 { get; set; }
        public decimal? R1I7 { get; set; }
        public decimal? R2I2 { get; set; }
        public decimal? R2I3 { get; set; }
        public decimal? R2I4 { get; set; }
        public decimal? R2I5 { get; set; }
        public decimal? R2I6 { get; set; }
        public decimal? R2I7 { get; set; }
        public decimal? R3I2 { get; set; }
        public decimal? R3I3 { get; set; }
        public decimal? R3I4 { get; set; }
        public decimal? R3I5 { get; set; }
        public decimal? R3I6 { get; set; }
        public decimal? R3I7 { get; set; }
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
        public string PrCodereportform { get; set; }

        public virtual ICollection<FsRepVnk178List> FsRepVnk178List { get; set; }
        public virtual ICollection<FsT01Vnk178List> FsT01Vnk178List { get; set; }
        public virtual ICollection<FsT02Vnk178List> FsT02Vnk178List { get; set; }
        public virtual ICollection<FsT03Vnk178List> FsT03Vnk178List { get; set; }
    }
}
