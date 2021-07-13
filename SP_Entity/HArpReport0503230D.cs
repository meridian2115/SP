using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class HArpReport0503230D
    {
        public HArpReport0503230D()
        {
            HfsActiveTabr1230List = new HashSet<HfsActiveTabr1230List>();
            HfsInfo2019Dnd230List = new HashSet<HfsInfo2019Dnd230List>();
            HfsInfo2019Id230List = new HashSet<HfsInfo2019Id230List>();
            HfsInfo2019T19230List = new HashSet<HfsInfo2019T19230List>();
            HfsInfoDnd230List = new HashSet<HfsInfoDnd230List>();
            HfsInfoFs230List = new HashSet<HfsInfoFs230List>();
            HfsInfoId230List = new HashSet<HfsInfoId230List>();
            HfsInfoPi230List = new HashSet<HfsInfoPi230List>();
            HfsInfoPu230List = new HashSet<HfsInfoPu230List>();
            HfsInfoSe230List = new HashSet<HfsInfoSe230List>();
            HfsInfoTa230List = new HashSet<HfsInfoTa230List>();
            HfsInfoTabr3230List = new HashSet<HfsInfoTabr3230List>();
            HfsInfoTb230List = new HashSet<HfsInfoTb230List>();
            HfsInfoUr230List = new HashSet<HfsInfoUr230List>();
            HfsPassiveTabr2230List = new HashSet<HfsPassiveTabr2230List>();
        }

        public decimal Id { get; set; }
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

        public virtual ICollection<HfsActiveTabr1230List> HfsActiveTabr1230List { get; set; }
        public virtual ICollection<HfsInfo2019Dnd230List> HfsInfo2019Dnd230List { get; set; }
        public virtual ICollection<HfsInfo2019Id230List> HfsInfo2019Id230List { get; set; }
        public virtual ICollection<HfsInfo2019T19230List> HfsInfo2019T19230List { get; set; }
        public virtual ICollection<HfsInfoDnd230List> HfsInfoDnd230List { get; set; }
        public virtual ICollection<HfsInfoFs230List> HfsInfoFs230List { get; set; }
        public virtual ICollection<HfsInfoId230List> HfsInfoId230List { get; set; }
        public virtual ICollection<HfsInfoPi230List> HfsInfoPi230List { get; set; }
        public virtual ICollection<HfsInfoPu230List> HfsInfoPu230List { get; set; }
        public virtual ICollection<HfsInfoSe230List> HfsInfoSe230List { get; set; }
        public virtual ICollection<HfsInfoTa230List> HfsInfoTa230List { get; set; }
        public virtual ICollection<HfsInfoTabr3230List> HfsInfoTabr3230List { get; set; }
        public virtual ICollection<HfsInfoTb230List> HfsInfoTb230List { get; set; }
        public virtual ICollection<HfsInfoUr230List> HfsInfoUr230List { get; set; }
        public virtual ICollection<HfsPassiveTabr2230List> HfsPassiveTabr2230List { get; set; }
    }
}
