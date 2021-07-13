using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class DcArpReport0503230D
    {
        public DcArpReport0503230D()
        {
            Fs019Dnd230List = new HashSet<Fs019Dnd230List>();
            Fs2019Id230List = new HashSet<Fs2019Id230List>();
            FsActiveTabr1230List = new HashSet<FsActiveTabr1230List>();
            FsInfo2019230List = new HashSet<FsInfo2019230List>();
            FsInfoDnd230List = new HashSet<FsInfoDnd230List>();
            FsInfoFs230List = new HashSet<FsInfoFs230List>();
            FsInfoId230List = new HashSet<FsInfoId230List>();
            FsInfoPi230List = new HashSet<FsInfoPi230List>();
            FsInfoPu230List = new HashSet<FsInfoPu230List>();
            FsInfoSe230List = new HashSet<FsInfoSe230List>();
            FsInfoTa230List = new HashSet<FsInfoTa230List>();
            FsInfoTabr3230List = new HashSet<FsInfoTabr3230List>();
            FsInfoTb230List = new HashSet<FsInfoTb230List>();
            FsInfoUr230List = new HashSet<FsInfoUr230List>();
            FsPassiveTabr2230List = new HashSet<FsPassiveTabr2230List>();
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
        public decimal? Test { get; set; }
        public string InfoPucountsum { get; set; }
        public string InfoTacountsum { get; set; }
        public string InfoFscountsum { get; set; }
        public string InfoIdcountsum { get; set; }
        public string InfoSecountsum { get; set; }
        public string InfoUrcountsum { get; set; }
        public string InfoDndcountsum { get; set; }
        public string InfoTbcountsum { get; set; }
        public string InfoPicountsum { get; set; }
        public string ReorgRepor { get; set; }
        public string ReorgReporKod { get; set; }
        public string ReorgNameGlava { get; set; }
        public string ReorgGlavaBk { get; set; }
        public string Typebalance { get; set; }
        public string TelIsp { get; set; }
        public DateTime? Date01012018 { get; set; }

        public virtual ICollection<Fs019Dnd230List> Fs019Dnd230List { get; set; }
        public virtual ICollection<Fs2019Id230List> Fs2019Id230List { get; set; }
        public virtual ICollection<FsActiveTabr1230List> FsActiveTabr1230List { get; set; }
        public virtual ICollection<FsInfo2019230List> FsInfo2019230List { get; set; }
        public virtual ICollection<FsInfoDnd230List> FsInfoDnd230List { get; set; }
        public virtual ICollection<FsInfoFs230List> FsInfoFs230List { get; set; }
        public virtual ICollection<FsInfoId230List> FsInfoId230List { get; set; }
        public virtual ICollection<FsInfoPi230List> FsInfoPi230List { get; set; }
        public virtual ICollection<FsInfoPu230List> FsInfoPu230List { get; set; }
        public virtual ICollection<FsInfoSe230List> FsInfoSe230List { get; set; }
        public virtual ICollection<FsInfoTa230List> FsInfoTa230List { get; set; }
        public virtual ICollection<FsInfoTabr3230List> FsInfoTabr3230List { get; set; }
        public virtual ICollection<FsInfoTb230List> FsInfoTb230List { get; set; }
        public virtual ICollection<FsInfoUr230List> FsInfoUr230List { get; set; }
        public virtual ICollection<FsPassiveTabr2230List> FsPassiveTabr2230List { get; set; }
    }
}
