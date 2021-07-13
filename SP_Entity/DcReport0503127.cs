using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class DcReport0503127
    {
        public DcReport0503127()
        {
            FsBeExpenseList = new HashSet<FsBeExpenseList>();
            FsBrRevenueList = new HashSet<FsBrRevenueList>();
            FsSfDecreaseList = new HashSet<FsSfDecreaseList>();
            FsSfDomesticList = new HashSet<FsSfDomesticList>();
            FsSfExternalList = new HashSet<FsSfExternalList>();
            FsSfIncreaseList = new HashSet<FsSfIncreaseList>();
        }

        public decimal Docid { get; set; }
        public decimal? Version { get; set; }
        public string Surrogat { get; set; }
        public decimal? BrC4R010 { get; set; }
        public decimal? BrC5R010 { get; set; }
        public decimal? BrC6R010 { get; set; }
        public decimal? BrC7R010 { get; set; }
        public decimal? BrC8R010 { get; set; }
        public decimal? BrC9R010 { get; set; }
        public decimal? BeC4R200 { get; set; }
        public decimal? BeC5R200 { get; set; }
        public decimal? BeC6R200 { get; set; }
        public decimal? BeC7R200 { get; set; }
        public decimal? BeC8R200 { get; set; }
        public decimal? BeC9R200 { get; set; }
        public decimal? BeC10R200 { get; set; }
        public decimal? BeC11R200 { get; set; }
        public decimal? BeC6R450 { get; set; }
        public decimal? BeC7R450 { get; set; }
        public decimal? BeC8R450 { get; set; }
        public decimal? BeC9R450 { get; set; }
        public decimal? SfC4R500 { get; set; }
        public decimal? SfC5R500 { get; set; }
        public decimal? SfC6R500 { get; set; }
        public decimal? SfC7R500 { get; set; }
        public decimal? SfC8R500 { get; set; }
        public decimal? SfC9R500 { get; set; }
        public decimal? SfC4R520 { get; set; }
        public decimal? SfC5R520 { get; set; }
        public decimal? SfC6R520 { get; set; }
        public decimal? SfC7R520 { get; set; }
        public decimal? SfC8R520 { get; set; }
        public decimal? SfC9R520 { get; set; }
        public decimal? SfC4R620 { get; set; }
        public decimal? SfC5R620 { get; set; }
        public decimal? SfC6R620 { get; set; }
        public decimal? SfC7R620 { get; set; }
        public decimal? SfC8R620 { get; set; }
        public decimal? SfC9R620 { get; set; }
        public decimal? SfC4R700 { get; set; }
        public decimal? SfC6R700 { get; set; }
        public decimal? SfC7R700 { get; set; }
        public decimal? SfC8R700 { get; set; }
        public decimal? SfC9R700 { get; set; }
        public decimal? SfC4R710 { get; set; }
        public decimal? SfC6R710 { get; set; }
        public decimal? SfC7R710 { get; set; }
        public decimal? SfC8R710 { get; set; }
        public decimal? SfC4R720 { get; set; }
        public decimal? SfC6R720 { get; set; }
        public decimal? SfC7R720 { get; set; }
        public decimal? SfC8R720 { get; set; }
        public decimal? SfC5R800 { get; set; }
        public decimal? SfC6R800 { get; set; }
        public decimal? SfC7R800 { get; set; }
        public decimal? SfC8R800 { get; set; }
        public decimal? SfC5R810 { get; set; }
        public decimal? SfC6R810 { get; set; }
        public decimal? SfC8R810 { get; set; }
        public decimal? SfC5R811 { get; set; }
        public decimal? SfC6R811 { get; set; }
        public decimal? SfC8R811 { get; set; }
        public decimal? SfC5R812 { get; set; }
        public decimal? SfC6R812 { get; set; }
        public decimal? SfC8R812 { get; set; }
        public decimal? SfC6R820 { get; set; }
        public decimal? SfC7R820 { get; set; }
        public decimal? SfC8R820 { get; set; }
        public decimal? SfC6R821 { get; set; }
        public decimal? SfC7R821 { get; set; }
        public decimal? SfC8R821 { get; set; }
        public decimal? SfC6R822 { get; set; }
        public decimal? SfC7R822 { get; set; }
        public decimal? SfC8R822 { get; set; }
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
        public string Namtip { get; set; }
        public DateTime? Dataarp7238 { get; set; }
        public string Numorder { get; set; }
        public string Pointorder { get; set; }
        public decimal? Year { get; set; }
        public decimal? Yeararp7238 { get; set; }

        public virtual ICollection<FsBeExpenseList> FsBeExpenseList { get; set; }
        public virtual ICollection<FsBrRevenueList> FsBrRevenueList { get; set; }
        public virtual ICollection<FsSfDecreaseList> FsSfDecreaseList { get; set; }
        public virtual ICollection<FsSfDomesticList> FsSfDomesticList { get; set; }
        public virtual ICollection<FsSfExternalList> FsSfExternalList { get; set; }
        public virtual ICollection<FsSfIncreaseList> FsSfIncreaseList { get; set; }
    }
}
