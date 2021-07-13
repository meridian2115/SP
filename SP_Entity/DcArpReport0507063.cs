using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class DcArpReport0507063
    {
        public DcArpReport0507063()
        {
            FsT10507063List = new HashSet<FsT10507063List>();
            FsT20507063List = new HashSet<FsT20507063List>();
            FsT30507063List = new HashSet<FsT30507063List>();
            FsT40507063List = new HashSet<FsT40507063List>();
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
        public string SeExecutorTel { get; set; }
        public decimal? S0BalYearStart { get; set; }
        public decimal? S0BalYearEnd { get; set; }
        public decimal? S1S1BalNy { get; set; }
        public decimal? S1S1BalDate { get; set; }
        public DateTime? S1S1Date { get; set; }
        public decimal? S2S2BalNyR { get; set; }
        public decimal? S2S2BalNyD { get; set; }
        public decimal? S2S2KrC5 { get; set; }
        public decimal? S2S2KrC7 { get; set; }
        public decimal? S2S2KrC9 { get; set; }
        public decimal? S2S2BalDateD { get; set; }
        public decimal? S2S2BalDateR { get; set; }
        public DateTime? S2S2Date { get; set; }
        public decimal? S3S3BalNyR { get; set; }
        public decimal? S3S3BalNyE { get; set; }
        public decimal? S3S3BalDateE { get; set; }
        public decimal? S3S3BalDateR { get; set; }
        public DateTime? S3S3Date { get; set; }
        public decimal? S3S3KrC5 { get; set; }
        public decimal? S3S3KrC7 { get; set; }
        public decimal? S3S3KrC9 { get; set; }
        public decimal? S4S4BalNyR { get; set; }
        public decimal? S4S4BalNyF { get; set; }
        public decimal? S4S4BalDateF { get; set; }
        public decimal? S4S4BalDateR { get; set; }
        public DateTime? S4S4Date { get; set; }
        public decimal? S4S4KrC5 { get; set; }
        public decimal? S4S4KrC7 { get; set; }
        public decimal? S4S4KrC9 { get; set; }
        public string Ord { get; set; }

        public virtual ICollection<FsT10507063List> FsT10507063List { get; set; }
        public virtual ICollection<FsT20507063List> FsT20507063List { get; set; }
        public virtual ICollection<FsT30507063List> FsT30507063List { get; set; }
        public virtual ICollection<FsT40507063List> FsT40507063List { get; set; }
    }
}
