using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class DcArpReport05037302019
    {
        public DcArpReport05037302019()
        {
            Fs0503730SpravkaList = new HashSet<Fs0503730SpravkaList>();
            FsBa19Ba730List = new HashSet<FsBa19Ba730List>();
            FsBa2019T040730List = new HashSet<FsBa2019T040730List>();
            FsBa2019T200730List = new HashSet<FsBa2019T200730List>();
            FsBa2020T040730List = new HashSet<FsBa2020T040730List>();
            FsBa2020T200730List = new HashSet<FsBa2020T200730List>();
            FsBa21Ba730List = new HashSet<FsBa21Ba730List>();
            FsT10503730List = new HashSet<FsT10503730List>();
            FsT20503730List = new HashSet<FsT20503730List>();
        }

        public decimal Docid { get; set; }
        public decimal? Version { get; set; }
        public string Ord { get; set; }
        public string ExecuterTel { get; set; }
        public string PfnLeader { get; set; }
        public string PfnChiefAcc { get; set; }
        public string PfnLeaderOfFes { get; set; }
        public string PfnPostLeader { get; set; }
        public string PfnPostChiefAcc { get; set; }
        public string PfnPostLeaderOf { get; set; }
        public string PfnExecutor { get; set; }
        public string PfnPostExecutor { get; set; }
        public string PfnPhone { get; set; }
        public DateTime? Date01012018 { get; set; }
        public string Nameseparatedivision { get; set; }
        public string Namefounder { get; set; }
        public string Namebodyactingfounder { get; set; }
        public string Okpo1 { get; set; }
        public string Inn1 { get; set; }
        public string Codefounder { get; set; }
        public string Codebodyactingfounder { get; set; }
        public string Countline040 { get; set; }
        public string Countline200 { get; set; }

        public virtual ICollection<Fs0503730SpravkaList> Fs0503730SpravkaList { get; set; }
        public virtual ICollection<FsBa19Ba730List> FsBa19Ba730List { get; set; }
        public virtual ICollection<FsBa2019T040730List> FsBa2019T040730List { get; set; }
        public virtual ICollection<FsBa2019T200730List> FsBa2019T200730List { get; set; }
        public virtual ICollection<FsBa2020T040730List> FsBa2020T040730List { get; set; }
        public virtual ICollection<FsBa2020T200730List> FsBa2020T200730List { get; set; }
        public virtual ICollection<FsBa21Ba730List> FsBa21Ba730List { get; set; }
        public virtual ICollection<FsT10503730List> FsT10503730List { get; set; }
        public virtual ICollection<FsT20503730List> FsT20503730List { get; set; }
    }
}
