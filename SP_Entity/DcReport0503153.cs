using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class DcReport0503153
    {
        public DcReport0503153()
        {
            FsBrRevenue153List = new HashSet<FsBrRevenue153List>();
            FsSfSourceList = new HashSet<FsSfSourceList>();
        }

        public decimal Docid { get; set; }
        public decimal? Version { get; set; }
        public string Ord { get; set; }
        public decimal? BrC2R011 { get; set; }
        public decimal? BrC3R011 { get; set; }
        public decimal? BrC4R011 { get; set; }
        public decimal? BrC5R011 { get; set; }
        public decimal? BrC6R011 { get; set; }
        public decimal? BrC7R011 { get; set; }
        public decimal? BrC8R011 { get; set; }
        public decimal? BrC9R011 { get; set; }
        public decimal? BrC10R011 { get; set; }
        public decimal? BrC11R011 { get; set; }
        public decimal? BrC12R011 { get; set; }
        public decimal? BrC13R011 { get; set; }
        public decimal? BrC14R011 { get; set; }
        public decimal? BrC15R011 { get; set; }
        public decimal? BrC16R011 { get; set; }
        public decimal? BrC17R011 { get; set; }
        public decimal? BrC18R011 { get; set; }
        public decimal? BrC19R011 { get; set; }
        public decimal? BrC20R011 { get; set; }
        public decimal? BrC21R011 { get; set; }
        public decimal? SfC2R021 { get; set; }
        public decimal? SfC3R021 { get; set; }
        public decimal? SfC4R021 { get; set; }
        public decimal? SfC5R021 { get; set; }
        public decimal? SfC6R021 { get; set; }
        public decimal? SfC7R021 { get; set; }
        public decimal? SfC8R021 { get; set; }
        public decimal? SfC9R021 { get; set; }
        public decimal? SfC10R021 { get; set; }
        public decimal? SfC11R021 { get; set; }
        public decimal? SfC12R021 { get; set; }
        public decimal? SfC13R021 { get; set; }
        public decimal? SfC14R021 { get; set; }
        public decimal? SfC15R021 { get; set; }
        public decimal? SfC16R021 { get; set; }
        public decimal? SfC17R021 { get; set; }
        public decimal? SfC18R021 { get; set; }
        public decimal? SfC19R021 { get; set; }
        public decimal? SfC20R021 { get; set; }
        public decimal? SfC21R021 { get; set; }
        public decimal? SfC2R022 { get; set; }
        public decimal? SfC3R022 { get; set; }
        public decimal? SfC4R022 { get; set; }
        public decimal? SfC5R022 { get; set; }
        public decimal? SfC6R022 { get; set; }
        public decimal? SfC7R022 { get; set; }
        public decimal? SfC8R022 { get; set; }
        public decimal? SfC9R022 { get; set; }
        public decimal? SfC10R022 { get; set; }
        public decimal? SfC11R022 { get; set; }
        public decimal? SfC12R022 { get; set; }
        public decimal? SfC13R022 { get; set; }
        public decimal? SfC14R022 { get; set; }
        public decimal? SfC15R022 { get; set; }
        public decimal? SfC16R022 { get; set; }
        public decimal? SfC17R022 { get; set; }
        public decimal? SfC18R022 { get; set; }
        public decimal? SfC19R022 { get; set; }
        public decimal? SfC20R022 { get; set; }
        public decimal? SfC21R022 { get; set; }
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

        public virtual ICollection<FsBrRevenue153List> FsBrRevenue153List { get; set; }
        public virtual ICollection<FsSfSourceList> FsSfSourceList { get; set; }
    }
}
