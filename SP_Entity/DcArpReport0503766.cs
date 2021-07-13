using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class DcArpReport0503766
    {
        public DcArpReport0503766()
        {
            FsR1T10503766R1List = new HashSet<FsR1T10503766R1List>();
            FsR2T10503766R2List = new HashSet<FsR2T10503766R2List>();
            FsR3T10503766R3List = new HashSet<FsR3T10503766R3List>();
            FsR3T20503766R3List = new HashSet<FsR3T20503766R3List>();
        }

        public decimal Docid { get; set; }
        public decimal? Version { get; set; }
        public string R1C2010 { get; set; }
        public decimal? R1C5010 { get; set; }
        public decimal? R1C6010 { get; set; }
        public decimal? R1C7010 { get; set; }
        public string R1C8010 { get; set; }
        public string R2C2200 { get; set; }
        public decimal? R2C5200 { get; set; }
        public decimal? R2C6200 { get; set; }
        public decimal? R2C7200 { get; set; }
        public string R2C8200 { get; set; }
        public string R2C2450 { get; set; }
        public decimal? R2C5450 { get; set; }
        public decimal? R2C6450 { get; set; }
        public decimal? R2C7450 { get; set; }
        public string R2C8450 { get; set; }
        public string R3C2500 { get; set; }
        public decimal? R3C5500 { get; set; }
        public decimal? R3C6500 { get; set; }
        public decimal? R3C7500 { get; set; }
        public string R3C8500 { get; set; }
        public string R3C2520 { get; set; }
        public string R3C3520 { get; set; }
        public string R3C4520 { get; set; }
        public decimal? R3C5520 { get; set; }
        public decimal? R3C6520 { get; set; }
        public decimal? R3C7520 { get; set; }
        public string R3C8520 { get; set; }
        public string R3C2620 { get; set; }
        public string R3C3620 { get; set; }
        public string R3C4620 { get; set; }
        public decimal? R3C5620 { get; set; }
        public decimal? R3C6620 { get; set; }
        public decimal? R3C7620 { get; set; }
        public string R3C8620 { get; set; }
        public string EntNameseparatedivision { get; set; }
        public string EntCodeseparatedivision { get; set; }
        public string EntNamefounder { get; set; }
        public string EntCodefounder { get; set; }
        public string EntNamebodyactfounder { get; set; }
        public string EntCodebodyactfounder { get; set; }
        public string EntOkpobodyactfounder { get; set; }
        public bool? EntSubDiv { get; set; }
        public string PfnLeader { get; set; }
        public string PfnChiefAcc { get; set; }
        public string PfnLeaderOfFes { get; set; }
        public string PfnPostLeader { get; set; }
        public string PfnPostChiefAcc { get; set; }
        public string PfnPostLeaderOf { get; set; }
        public string PfnExecutor { get; set; }
        public string PfnPostExecutor { get; set; }
        public string PfnPhone { get; set; }
        public string SysNamtip { get; set; }
        public string SysOrd { get; set; }

        public virtual ICollection<FsR1T10503766R1List> FsR1T10503766R1List { get; set; }
        public virtual ICollection<FsR2T10503766R2List> FsR2T10503766R2List { get; set; }
        public virtual ICollection<FsR3T10503766R3List> FsR3T10503766R3List { get; set; }
        public virtual ICollection<FsR3T20503766R3List> FsR3T20503766R3List { get; set; }
    }
}
