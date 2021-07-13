using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class DcArpO0504072
    {
        public DcArpO0504072()
        {
            FsRaRevenuList = new HashSet<FsRaRevenuList>();
            FsRbRashodList = new HashSet<FsRbRashodList>();
            FsRcSourseList = new HashSet<FsRcSourseList>();
            FsRdKvrList = new HashSet<FsRdKvrList>();
            FsReFkrList = new HashSet<FsReFkrList>();
        }

        public decimal Docid { get; set; }
        public decimal? Version { get; set; }
        public string System { get; set; }
        public string System1 { get; set; }
        public string Ord { get; set; }
        public string PfnPfnLeader { get; set; }
        public string PfnPfnChiefAcc { get; set; }
        public string PfnPfnLeaderOfFes { get; set; }
        public string PfnPfnPostLeader { get; set; }
        public string PfnPfnPostChiefAcc { get; set; }
        public string PfnPfnPostLeaderOf { get; set; }
        public string PfnPfnExecutor { get; set; }
        public string PfnPfnPostExecutor { get; set; }
        public string PfnPfnPhone { get; set; }
        public decimal? RaC3R01 { get; set; }
        public decimal? RbC3R02 { get; set; }
        public decimal? RbC4R02 { get; set; }
        public decimal? RbC5R02 { get; set; }
        public decimal? RbC6R02 { get; set; }
        public decimal? RbC7R02 { get; set; }
        public decimal? RbC8R02 { get; set; }
        public decimal? RbC9R02 { get; set; }
        public decimal? RbC10R02 { get; set; }
        public decimal? RbC11R02 { get; set; }
        public decimal? RbC12R02 { get; set; }
        public decimal? RbC13R02 { get; set; }
        public decimal? RbC14R02 { get; set; }
        public decimal? RbC15R02 { get; set; }
        public decimal? RbC16R02 { get; set; }
        public decimal? RbC17R02 { get; set; }
        public decimal? RbC18R02 { get; set; }
        public decimal? RbC19R02 { get; set; }
        public decimal? RbC20R02 { get; set; }
        public decimal? RbC21R02 { get; set; }
        public decimal? RbC22R02 { get; set; }
        public decimal? RbC23R02 { get; set; }
        public decimal? RbC24R02 { get; set; }
        public decimal? RbC25R02 { get; set; }
        public decimal? RbC26R02 { get; set; }
        public decimal? RbC27R02 { get; set; }
        public decimal? RbC28R02 { get; set; }
        public decimal? RbC29R02 { get; set; }
        public decimal? RbC30R02 { get; set; }
        public decimal? RbC31R02 { get; set; }
        public decimal? RbC32R02 { get; set; }
        public decimal? RbC33R02 { get; set; }
        public decimal? RcC3R03 { get; set; }
        public decimal? RcC4R03 { get; set; }
        public decimal? RcC5R03 { get; set; }
        public decimal? RcC6R03 { get; set; }
        public decimal? RdC3R04 { get; set; }
        public decimal? RdC4R04 { get; set; }
        public decimal? ReC3R05 { get; set; }
        public decimal? ReC4R05 { get; set; }
        public string CodeTofk { get; set; }
        public string NameTofk { get; set; }
        public decimal? RbnC6R02 { get; set; }
        public decimal? RbnC7R02 { get; set; }
        public decimal? RbnC8R02 { get; set; }
        public decimal? RbnC9R02 { get; set; }
        public decimal? RbnC10R02 { get; set; }
        public decimal? RbnC11R02 { get; set; }
        public decimal? RbnC12R02 { get; set; }
        public decimal? RbnC13R02 { get; set; }
        public decimal? RbnC14R02 { get; set; }
        public decimal? RbnC15R02 { get; set; }
        public decimal? RbnC16R02 { get; set; }
        public decimal? RbnC17R02 { get; set; }
        public decimal? RbnC18R02 { get; set; }
        public decimal? RbnC19R02 { get; set; }
        public decimal? RbnC20R02 { get; set; }
        public decimal? RbnC21R02 { get; set; }
        public decimal? RbnC22R02 { get; set; }
        public decimal? RbnC23R02 { get; set; }
        public decimal? RbnC24R02 { get; set; }
        public decimal? RbnC25R02 { get; set; }
        public decimal? RbnC26R02 { get; set; }
        public decimal? RbnC27R02 { get; set; }
        public decimal? RbnC28R02 { get; set; }
        public decimal? RbnC29R02 { get; set; }
        public decimal? RbnC30R02 { get; set; }
        public decimal? RbnC31R02 { get; set; }
        public decimal? RbnC32R02 { get; set; }
        public decimal? RbnC33R02 { get; set; }
        public decimal? RbnC34R02 { get; set; }
        public decimal? RbnC35R02 { get; set; }
        public decimal? RbnC36R02 { get; set; }
        public decimal? RbnC37R02 { get; set; }
        public decimal? RbnC38R02 { get; set; }
        public decimal? RbnC39R02 { get; set; }
        public decimal? RbnC40R02 { get; set; }

        public virtual ICollection<FsRaRevenuList> FsRaRevenuList { get; set; }
        public virtual ICollection<FsRbRashodList> FsRbRashodList { get; set; }
        public virtual ICollection<FsRcSourseList> FsRcSourseList { get; set; }
        public virtual ICollection<FsRdKvrList> FsRdKvrList { get; set; }
        public virtual ICollection<FsReFkrList> FsReFkrList { get; set; }
    }
}
