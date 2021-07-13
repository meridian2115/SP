using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class DcArpReport0507012
    {
        public DcArpReport0507012()
        {
            FsT10507012List = new HashSet<FsT10507012List>();
            FsT1190507012List = new HashSet<FsT1190507012List>();
            FsT20507012List = new HashSet<FsT20507012List>();
            FsT2190507012List = new HashSet<FsT2190507012List>();
            FsT30507012List = new HashSet<FsT30507012List>();
            FsT3190507012List = new HashSet<FsT3190507012List>();
        }

        public decimal Docid { get; set; }
        public decimal? Version { get; set; }
        public decimal? TotalS11 { get; set; }
        public decimal? TotalS12 { get; set; }
        public decimal? TotalS13 { get; set; }
        public decimal? S21 { get; set; }
        public decimal? S22 { get; set; }
        public decimal? S23 { get; set; }
        public decimal? S31 { get; set; }
        public decimal? S32 { get; set; }
        public decimal? S33 { get; set; }
        public string Ord { get; set; }
        public string HrPnfLeader { get; set; }
        public string HrPnfChiefAcc { get; set; }
        public string HrPnfLeaderOfFes { get; set; }
        public string HrPnfPostLeader { get; set; }
        public string HrPnfPostChiefAcc { get; set; }
        public string HrPnfPostLeaderOf { get; set; }
        public string HrPnfExecutor { get; set; }
        public string HrPnfPostExecutor { get; set; }
        public string HrPnfPhone { get; set; }
        public decimal? TotalT1s3 { get; set; }
        public decimal? TotalT1s4 { get; set; }
        public decimal? TotalT1s5 { get; set; }
        public decimal? TotalT2s3 { get; set; }
        public decimal? TotalT2s4 { get; set; }
        public decimal? TotalT2s5 { get; set; }
        public decimal? TotalT3s3 { get; set; }
        public decimal? TotalT3s4 { get; set; }
        public decimal? TotalT3s5 { get; set; }

        public virtual ICollection<FsT10507012List> FsT10507012List { get; set; }
        public virtual ICollection<FsT1190507012List> FsT1190507012List { get; set; }
        public virtual ICollection<FsT20507012List> FsT20507012List { get; set; }
        public virtual ICollection<FsT2190507012List> FsT2190507012List { get; set; }
        public virtual ICollection<FsT30507012List> FsT30507012List { get; set; }
        public virtual ICollection<FsT3190507012List> FsT3190507012List { get; set; }
    }
}
