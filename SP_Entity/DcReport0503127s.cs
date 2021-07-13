using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class DcReport0503127s
    {
        public DcReport0503127s()
        {
            FsBeExp127sList = new HashSet<FsBeExp127sList>();
        }

        public decimal Docid { get; set; }
        public decimal? Version { get; set; }
        public string Surrogat { get; set; }
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
        public decimal? Year { get; set; }
        public DateTime? Dataarp7238 { get; set; }
        public decimal? Yeararp7238 { get; set; }
        public string Numorder { get; set; }
        public string Pointorder { get; set; }

        public virtual ICollection<FsBeExp127sList> FsBeExp127sList { get; set; }
    }
}
