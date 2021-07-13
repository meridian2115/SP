using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class HReport0503127
    {
        public HReport0503127()
        {
            HfsBeExpenseList = new HashSet<HfsBeExpenseList>();
            HfsBrRevenueList = new HashSet<HfsBrRevenueList>();
            HfsSfDecreaseList = new HashSet<HfsSfDecreaseList>();
            HfsSfDomesticList = new HashSet<HfsSfDomesticList>();
            HfsSfExternalList = new HashSet<HfsSfExternalList>();
            HfsSfIncreaseList = new HashSet<HfsSfIncreaseList>();
        }

        public decimal Id { get; set; }
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
        public string Numorder { get; set; }
        public string Pointorder { get; set; }

        public virtual ICollection<HfsBeExpenseList> HfsBeExpenseList { get; set; }
        public virtual ICollection<HfsBrRevenueList> HfsBrRevenueList { get; set; }
        public virtual ICollection<HfsSfDecreaseList> HfsSfDecreaseList { get; set; }
        public virtual ICollection<HfsSfDomesticList> HfsSfDomesticList { get; set; }
        public virtual ICollection<HfsSfExternalList> HfsSfExternalList { get; set; }
        public virtual ICollection<HfsSfIncreaseList> HfsSfIncreaseList { get; set; }
    }
}
