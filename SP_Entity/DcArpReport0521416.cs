using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class DcArpReport0521416
    {
        public DcArpReport0521416()
        {
            FsR1Revenue416List = new HashSet<FsR1Revenue416List>();
            FsR2Domestic416List = new HashSet<FsR2Domestic416List>();
        }

        public decimal Docid { get; set; }
        public decimal? Version { get; set; }
        public decimal? R1C6 { get; set; }
        public decimal? R2C4 { get; set; }
        public decimal? R2C4All { get; set; }
        public string SeSndLeader { get; set; }
        public string SeSndChiefAcc { get; set; }
        public string SeSndLeaderOfFes { get; set; }
        public string SeSndPostLeader { get; set; }
        public string SeSndPostChiefAcc { get; set; }
        public string SeSndPostLeaderOf { get; set; }
        public string SeSndExecutor { get; set; }
        public string SeSndPostExecutor { get; set; }
        public string SeSndPhone { get; set; }
        public string SeRcpLeader { get; set; }
        public string SeRcpChiefAcc { get; set; }
        public string SeRcpLeaderOfFes { get; set; }
        public string SeRcpPostLeader { get; set; }
        public string SeRcpPostChiefAcc { get; set; }
        public string SeRcpPostLeaderOf { get; set; }
        public string SeRcpExecutor { get; set; }
        public string SeRcpPostExecutor { get; set; }
        public string SeRcpPhone { get; set; }
        public string SeTelSender { get; set; }
        public string SeTelReceiver { get; set; }
        public string Ord { get; set; }
        public string Surrogat { get; set; }
        public string Tofkcodesender { get; set; }
        public string Tofkcodereceiver { get; set; }
        public string Tofknamesender { get; set; }
        public string Tofknamereceiver { get; set; }

        public virtual ICollection<FsR1Revenue416List> FsR1Revenue416List { get; set; }
        public virtual ICollection<FsR2Domestic416List> FsR2Domestic416List { get; set; }
    }
}
