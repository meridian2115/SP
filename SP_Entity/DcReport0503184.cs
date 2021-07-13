using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class DcReport0503184
    {
        public DcReport0503184()
        {
            FsBr184RevenueList = new HashSet<FsBr184RevenueList>();
            FsSf184DomesticList = new HashSet<FsSf184DomesticList>();
        }

        public decimal Docid { get; set; }
        public decimal? Version { get; set; }
        public string BrRvTotalC2R0101 { get; set; }
        public decimal? BrRvTotalC4R0101 { get; set; }
        public string SfDomTotalC2R5201 { get; set; }
        public decimal? SfDomTotalC4R5201 { get; set; }
        public string SfIncTotalC2R710 { get; set; }
        public decimal? SfIncTotalC4R710 { get; set; }
        public string PfnLeader { get; set; }
        public string PfnChiefAcc { get; set; }
        public string PfnLeaderOfFes { get; set; }
        public string PfnPostLeader { get; set; }
        public string PfnPostChiefAcc { get; set; }
        public string PfnPostLeaderOf { get; set; }
        public string PfnExecutor { get; set; }
        public string PfnPostExecutor { get; set; }
        public string PfnPhone { get; set; }
        public string Ord { get; set; }

        public virtual ICollection<FsBr184RevenueList> FsBr184RevenueList { get; set; }
        public virtual ICollection<FsSf184DomesticList> FsSf184DomesticList { get; set; }
    }
}
