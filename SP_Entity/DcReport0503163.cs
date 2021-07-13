using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class DcReport0503163
    {
        public DcReport0503163()
        {
            FsBeExp0503163List = new HashSet<FsBeExp0503163List>();
            FsSfDom0503163List = new HashSet<FsSfDom0503163List>();
        }

        public decimal Docid { get; set; }
        public decimal? Version { get; set; }
        public string HrSingLeader { get; set; }
        public string HrSingChiefAcc { get; set; }
        public string HrSingLeaderOfFes { get; set; }
        public string HrSingPostLeader { get; set; }
        public string HrSingPostChiefAcc { get; set; }
        public string HrSingPostLeaderOf { get; set; }
        public string HrSingExecutor { get; set; }
        public string HrSingPostExecutor { get; set; }
        public string HrSingPhone { get; set; }
        public decimal? BeC2R200 { get; set; }
        public decimal? BeC3R200 { get; set; }
        public decimal? BeC4R200 { get; set; }
        public decimal? SfC4R500 { get; set; }
        public decimal? SfC3R500 { get; set; }
        public decimal? SfC2R500 { get; set; }
        public string Ord { get; set; }
        public string Telephone { get; set; }
        public decimal? C4 { get; set; }
        public decimal? C3 { get; set; }
        public decimal? C2 { get; set; }
        public decimal? Currentyear { get; set; }

        public virtual ICollection<FsBeExp0503163List> FsBeExp0503163List { get; set; }
        public virtual ICollection<FsSfDom0503163List> FsSfDom0503163List { get; set; }
    }
}
