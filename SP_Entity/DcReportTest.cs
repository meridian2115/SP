using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class DcReportTest
    {
        public DcReportTest()
        {
            FsBeExpenseTestList = new HashSet<FsBeExpenseTestList>();
            FsBrRevenueTestList = new HashSet<FsBrRevenueTestList>();
            FsR1T1324TestList = new HashSet<FsR1T1324TestList>();
            FsR2T3324TestList = new HashSet<FsR2T3324TestList>();
            FsR3T5324TestList = new HashSet<FsR3T5324TestList>();
        }

        public decimal Docid { get; set; }
        public decimal? Version { get; set; }
        public decimal? R1C5R1 { get; set; }
        public decimal? R1C6R1 { get; set; }
        public decimal? R1C7R1 { get; set; }
        public decimal? R1C8R1 { get; set; }
        public decimal? R1C9R1 { get; set; }
        public decimal? R1C10R1 { get; set; }
        public decimal? R1C11R1 { get; set; }
        public decimal? R1C12R1 { get; set; }
        public decimal? R1C13R1 { get; set; }
        public decimal? R2C4R2 { get; set; }
        public string SeLeader { get; set; }
        public string SeChiefAcc { get; set; }
        public string SeLeaderOfFes { get; set; }
        public string SePostLeader { get; set; }
        public string SePostChiefAcc { get; set; }
        public string SePostLeaderOf { get; set; }
        public string SeExecutor { get; set; }
        public string SePostExecutor { get; set; }
        public string SePhone { get; set; }
        public string Ord { get; set; }
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

        public virtual ICollection<FsBeExpenseTestList> FsBeExpenseTestList { get; set; }
        public virtual ICollection<FsBrRevenueTestList> FsBrRevenueTestList { get; set; }
        public virtual ICollection<FsR1T1324TestList> FsR1T1324TestList { get; set; }
        public virtual ICollection<FsR2T3324TestList> FsR2T3324TestList { get; set; }
        public virtual ICollection<FsR3T5324TestList> FsR3T5324TestList { get; set; }
    }
}
