using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class HReportTest
    {
        public HReportTest()
        {
            HfsBeExpenseTestList = new HashSet<HfsBeExpenseTestList>();
            HfsBrRevenueTestList = new HashSet<HfsBrRevenueTestList>();
        }

        public decimal Id { get; set; }
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

        public virtual ICollection<HfsBeExpenseTestList> HfsBeExpenseTestList { get; set; }
        public virtual ICollection<HfsBrRevenueTestList> HfsBrRevenueTestList { get; set; }
    }
}
