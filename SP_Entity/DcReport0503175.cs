using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class DcReport0503175
    {
        public DcReport0503175()
        {
            FsS1T11175List = new HashSet<FsS1T11175List>();
            FsS1T21175List = new HashSet<FsS1T21175List>();
            FsS2T12175List = new HashSet<FsS2T12175List>();
            FsS2T22175List = new HashSet<FsS2T22175List>();
            FsS3T13175List = new HashSet<FsS3T13175List>();
            FsS3T23175List = new HashSet<FsS3T23175List>();
            FsS4T14175List = new HashSet<FsS4T14175List>();
            FsS4T24175List = new HashSet<FsS4T24175List>();
        }

        public decimal Docid { get; set; }
        public decimal? Version { get; set; }
        public decimal? S1SumT1 { get; set; }
        public decimal? S1SumT2 { get; set; }
        public decimal? S1SumS1 { get; set; }
        public decimal? S2SumT1 { get; set; }
        public decimal? S2SumT2 { get; set; }
        public decimal? S2SumS2 { get; set; }
        public decimal? S3SumS3 { get; set; }
        public decimal? S4SumS4 { get; set; }
        public string Ord { get; set; }
        public string PfnLeader { get; set; }
        public string PfnChiefAcc { get; set; }
        public string PfnLeaderOfFes { get; set; }
        public string PfnPostLeader { get; set; }
        public string PfnPostChiefAcc { get; set; }
        public string PfnPostLeaderOf { get; set; }
        public string PfnExecutor { get; set; }
        public string PfnPostExecutor { get; set; }
        public string PfnPhone { get; set; }
        public string ExecuterTel { get; set; }

        public virtual ICollection<FsS1T11175List> FsS1T11175List { get; set; }
        public virtual ICollection<FsS1T21175List> FsS1T21175List { get; set; }
        public virtual ICollection<FsS2T12175List> FsS2T12175List { get; set; }
        public virtual ICollection<FsS2T22175List> FsS2T22175List { get; set; }
        public virtual ICollection<FsS3T13175List> FsS3T13175List { get; set; }
        public virtual ICollection<FsS3T23175List> FsS3T23175List { get; set; }
        public virtual ICollection<FsS4T14175List> FsS4T14175List { get; set; }
        public virtual ICollection<FsS4T24175List> FsS4T24175List { get; set; }
    }
}
