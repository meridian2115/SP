using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class DcArpReport0503168D
    {
        public DcArpReport0503168D()
        {
            FsIk0503168List = new HashSet<FsIk0503168List>();
            FsMc0503168List = new HashSet<FsMc0503168List>();
            FsMcIk0503168List = new HashSet<FsMcIk0503168List>();
            FsNa0503168List = new HashSet<FsNa0503168List>();
        }

        public decimal Docid { get; set; }
        public decimal? Version { get; set; }
        public string Ord { get; set; }
        public string PfnLeader { get; set; }
        public string PfnChiefAcc { get; set; }
        public string PfnLeaderOfFes { get; set; }
        public string PfnPostLeader { get; set; }
        public string PfnPostChiefAcc { get; set; }
        public string PfnPostLeaderOf { get; set; }
        public string PfnExecutor { get; set; }
        public string PfnPostExecutor { get; set; }
        public string PfnPhone { get; set; }
        public string CodeKvfo { get; set; }
        public string Kindactivity { get; set; }
        public decimal? Refresh11g { get; set; }
        public string Typeproperty { get; set; }

        public virtual ICollection<FsIk0503168List> FsIk0503168List { get; set; }
        public virtual ICollection<FsMc0503168List> FsMc0503168List { get; set; }
        public virtual ICollection<FsMcIk0503168List> FsMcIk0503168List { get; set; }
        public virtual ICollection<FsNa0503168List> FsNa0503168List { get; set; }
    }
}
