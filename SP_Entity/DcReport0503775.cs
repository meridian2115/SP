using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class DcReport0503775
    {
        public DcReport0503775()
        {
            FsAcAicostList = new HashSet<FsAcAicostList>();
            FsAcAicostP775List = new HashSet<FsAcAicostP775List>();
            FsAcAicostT775List = new HashSet<FsAcAicostT775List>();
            FsAdAmiP775List = new HashSet<FsAdAmiP775List>();
            FsAdAmiT775List = new HashSet<FsAdAmiT775List>();
            FsAeAieconList = new HashSet<FsAeAieconList>();
            FsAeAieconP775List = new HashSet<FsAeAieconP775List>();
            FsAeAieconT775List = new HashSet<FsAeAieconT775List>();
            FsAiTaiP775List = new HashSet<FsAiTaiP775List>();
            FsAiTaiT775List = new HashSet<FsAiTaiT775List>();
            FsR1TaiList = new HashSet<FsR1TaiList>();
            FsR2AmiList = new HashSet<FsR2AmiList>();
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
        public decimal? AiC2R013 { get; set; }
        public decimal? AdC2R023 { get; set; }
        public decimal? AcC2R033 { get; set; }
        public decimal? AeC2R043 { get; set; }
        public string TelIsp { get; set; }

        public virtual ICollection<FsAcAicostList> FsAcAicostList { get; set; }
        public virtual ICollection<FsAcAicostP775List> FsAcAicostP775List { get; set; }
        public virtual ICollection<FsAcAicostT775List> FsAcAicostT775List { get; set; }
        public virtual ICollection<FsAdAmiP775List> FsAdAmiP775List { get; set; }
        public virtual ICollection<FsAdAmiT775List> FsAdAmiT775List { get; set; }
        public virtual ICollection<FsAeAieconList> FsAeAieconList { get; set; }
        public virtual ICollection<FsAeAieconP775List> FsAeAieconP775List { get; set; }
        public virtual ICollection<FsAeAieconT775List> FsAeAieconT775List { get; set; }
        public virtual ICollection<FsAiTaiP775List> FsAiTaiP775List { get; set; }
        public virtual ICollection<FsAiTaiT775List> FsAiTaiT775List { get; set; }
        public virtual ICollection<FsR1TaiList> FsR1TaiList { get; set; }
        public virtual ICollection<FsR2AmiList> FsR2AmiList { get; set; }
    }
}
