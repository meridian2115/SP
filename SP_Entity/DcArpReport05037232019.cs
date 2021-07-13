using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class DcArpReport05037232019
    {
        public DcArpReport05037232019()
        {
            FsC1T17232019List = new HashSet<FsC1T17232019List>();
            FsC2T27232019List = new HashSet<FsC2T27232019List>();
            FsC3T37232019List = new HashSet<FsC3T37232019List>();
            FsC407Exp723072019List = new HashSet<FsC407Exp723072019List>();
            FsC4Exp7232019List = new HashSet<FsC4Exp7232019List>();
        }

        public decimal Docid { get; set; }
        public decimal? Version { get; set; }
        public decimal? C4Sum900 { get; set; }
        public decimal? C407Sum9000 { get; set; }
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
        public DateTime? Dateminusyear { get; set; }
        public string Nameseparatedivision { get; set; }
        public string Codeseparatedivision { get; set; }
        public string Namefounder { get; set; }
        public string Codefounder { get; set; }
        public bool? SubDiv { get; set; }
        public decimal? Year { get; set; }

        public virtual ICollection<FsC1T17232019List> FsC1T17232019List { get; set; }
        public virtual ICollection<FsC2T27232019List> FsC2T27232019List { get; set; }
        public virtual ICollection<FsC3T37232019List> FsC3T37232019List { get; set; }
        public virtual ICollection<FsC407Exp723072019List> FsC407Exp723072019List { get; set; }
        public virtual ICollection<FsC4Exp7232019List> FsC4Exp7232019List { get; set; }
    }
}
