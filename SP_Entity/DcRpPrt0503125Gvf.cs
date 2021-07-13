using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class DcRpPrt0503125Gvf
    {
        public DcRpPrt0503125Gvf()
        {
            FsRepVnk125GvfList = new HashSet<FsRepVnk125GvfList>();
            FsT1125GvfList = new HashSet<FsT1125GvfList>();
            FsT12125GvfList = new HashSet<FsT12125GvfList>();
            FsT2125GvfList = new HashSet<FsT2125GvfList>();
            FsT213125GvfList = new HashSet<FsT213125GvfList>();
            FsT31125GvfList = new HashSet<FsT31125GvfList>();
            FsT3125GvfList = new HashSet<FsT3125GvfList>();
            FsT701125GvfList = new HashSet<FsT701125GvfList>();
            FsT702125GvfList = new HashSet<FsT702125GvfList>();
            FsT710125GvfList = new HashSet<FsT710125GvfList>();
            FsT8125GvfList = new HashSet<FsT8125GvfList>();
            FsT9125GvfList = new HashSet<FsT9125GvfList>();
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
        public string Ord { get; set; }
        public string Surrogat { get; set; }
        public DateTime? Logid { get; set; }
        public string PrCodereportform { get; set; }

        public virtual ICollection<FsRepVnk125GvfList> FsRepVnk125GvfList { get; set; }
        public virtual ICollection<FsT1125GvfList> FsT1125GvfList { get; set; }
        public virtual ICollection<FsT12125GvfList> FsT12125GvfList { get; set; }
        public virtual ICollection<FsT2125GvfList> FsT2125GvfList { get; set; }
        public virtual ICollection<FsT213125GvfList> FsT213125GvfList { get; set; }
        public virtual ICollection<FsT31125GvfList> FsT31125GvfList { get; set; }
        public virtual ICollection<FsT3125GvfList> FsT3125GvfList { get; set; }
        public virtual ICollection<FsT701125GvfList> FsT701125GvfList { get; set; }
        public virtual ICollection<FsT702125GvfList> FsT702125GvfList { get; set; }
        public virtual ICollection<FsT710125GvfList> FsT710125GvfList { get; set; }
        public virtual ICollection<FsT8125GvfList> FsT8125GvfList { get; set; }
        public virtual ICollection<FsT9125GvfList> FsT9125GvfList { get; set; }
    }
}
