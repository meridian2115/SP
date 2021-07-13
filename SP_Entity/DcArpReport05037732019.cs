using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class DcArpReport05037732019
    {
        public DcArpReport05037732019()
        {
            FsActR105037732020List = new HashSet<FsActR105037732020List>();
            FsActiveR10503773List = new HashSet<FsActiveR10503773List>();
            FsActiveR30503773List = new HashSet<FsActiveR30503773List>();
            FsPassR205037732020List = new HashSet<FsPassR205037732020List>();
            FsPassiveR20503773List = new HashSet<FsPassiveR20503773List>();
            FsPassiveR30503773List = new HashSet<FsPassiveR30503773List>();
            FsR47732021R4773List = new HashSet<FsR47732021R4773List>();
            FsR47732021T040773List = new HashSet<FsR47732021T040773List>();
            FsR47732021T200773List = new HashSet<FsR47732021T200773List>();
        }

        public decimal Docid { get; set; }
        public decimal? Version { get; set; }
        public string HrNameseparatedivision { get; set; }
        public string HrCodeseparatedivision { get; set; }
        public string HrNamefounder { get; set; }
        public string HrCodefounder { get; set; }
        public string HrNamebodyactingfounder { get; set; }
        public string HrCodebodyactingfounder { get; set; }
        public string HrNameKvfo { get; set; }
        public string HrCodeKvfo { get; set; }
        public string Ord { get; set; }
        public string CaCode { get; set; }
        public string CaName { get; set; }
        public string CaOgrn { get; set; }
        public string CaInn { get; set; }
        public string CaKpp { get; set; }
        public string CaCaLeader { get; set; }
        public string CaCaExecutor { get; set; }
        public string CaPostCaLeader { get; set; }
        public string CaPostCaExecutor { get; set; }
        public string CaCaExecutorMail { get; set; }
        public string PfnLeader { get; set; }
        public string PfnChiefAcc { get; set; }
        public string PfnLeaderOfFes { get; set; }
        public string PfnPostLeader { get; set; }
        public string PfnPostChiefAcc { get; set; }
        public string PfnPostLeaderOf { get; set; }
        public string PfnExecutor { get; set; }
        public string PfnPostExecutor { get; set; }
        public string PfnPhone { get; set; }
        public string Address { get; set; }
        public bool? SubDiv { get; set; }
        public string Cd373d { get; set; }
        public string Cd373z { get; set; }
        public string Cd373i { get; set; }
        public string Cd373c { get; set; }
        public string Cd373m { get; set; }
        public string Cd373t { get; set; }
        public string CustomerCode { get; set; }
        public decimal? C2R3Act { get; set; }
        public decimal? C2R3Pas { get; set; }
        public string Countline040 { get; set; }
        public string Countline200 { get; set; }

        public virtual ICollection<FsActR105037732020List> FsActR105037732020List { get; set; }
        public virtual ICollection<FsActiveR10503773List> FsActiveR10503773List { get; set; }
        public virtual ICollection<FsActiveR30503773List> FsActiveR30503773List { get; set; }
        public virtual ICollection<FsPassR205037732020List> FsPassR205037732020List { get; set; }
        public virtual ICollection<FsPassiveR20503773List> FsPassiveR20503773List { get; set; }
        public virtual ICollection<FsPassiveR30503773List> FsPassiveR30503773List { get; set; }
        public virtual ICollection<FsR47732021R4773List> FsR47732021R4773List { get; set; }
        public virtual ICollection<FsR47732021T040773List> FsR47732021T040773List { get; set; }
        public virtual ICollection<FsR47732021T200773List> FsR47732021T200773List { get; set; }
    }
}
