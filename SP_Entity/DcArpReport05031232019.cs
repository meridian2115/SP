using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class DcArpReport05031232019
    {
        public DcArpReport05031232019()
        {
            FsC1T11232019List = new HashSet<FsC1T11232019List>();
            FsC2T21232019List = new HashSet<FsC2T21232019List>();
            FsC31In1232019List = new HashSet<FsC31In1232019List>();
            FsC31Out1232019List = new HashSet<FsC31Out1232019List>();
            FsC3T31232019List = new HashSet<FsC3T31232019List>();
            FsC4Exp1232019List = new HashSet<FsC4Exp1232019List>();
            FsC4Ret1232019List = new HashSet<FsC4Ret1232019List>();
        }

        public decimal Docid { get; set; }
        public decimal? Version { get; set; }
        public decimal? C31SumR31800 { get; set; }
        public decimal? C31SumR31810 { get; set; }
        public decimal? C31SumR31820 { get; set; }
        public string C31Cdsubsec810 { get; set; }
        public string C31C4aR810 { get; set; }
        public string C31C4bR810 { get; set; }
        public string C31Cdsubsec820 { get; set; }
        public string C31C4aR820 { get; set; }
        public string C31C4bR820 { get; set; }
        public decimal? C4SumR4900 { get; set; }
        public decimal? C4SumR4980 { get; set; }
        public decimal? C4SumR4990 { get; set; }
        public string C4Cdsubsec990 { get; set; }
        public string C4Kvr990 { get; set; }
        public string HrPnfLeader { get; set; }
        public string HrPnfChiefAcc { get; set; }
        public string HrPnfLeaderOfFes { get; set; }
        public string HrPnfPostLeader { get; set; }
        public string HrPnfPostChiefAcc { get; set; }
        public string HrPnfPostLeaderOf { get; set; }
        public string HrPnfExecutor { get; set; }
        public string HrPnfPostExecutor { get; set; }
        public string HrPnfPhone { get; set; }
        public string HrOrd { get; set; }
        public string HrNamtip { get; set; }
        public string HrTelephone { get; set; }
        public DateTime? Dateminusyear { get; set; }

        public virtual ICollection<FsC1T11232019List> FsC1T11232019List { get; set; }
        public virtual ICollection<FsC2T21232019List> FsC2T21232019List { get; set; }
        public virtual ICollection<FsC31In1232019List> FsC31In1232019List { get; set; }
        public virtual ICollection<FsC31Out1232019List> FsC31Out1232019List { get; set; }
        public virtual ICollection<FsC3T31232019List> FsC3T31232019List { get; set; }
        public virtual ICollection<FsC4Exp1232019List> FsC4Exp1232019List { get; set; }
        public virtual ICollection<FsC4Ret1232019List> FsC4Ret1232019List { get; set; }
    }
}
