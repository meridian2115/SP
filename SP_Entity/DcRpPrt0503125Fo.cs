using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class DcRpPrt0503125Fo
    {
        public DcRpPrt0503125Fo()
        {
            FsRepVnk125FoList = new HashSet<FsRepVnk125FoList>();
            FsT01125List = new HashSet<FsT01125List>();
            FsT10125List = new HashSet<FsT10125List>();
            FsT11125List = new HashSet<FsT11125List>();
            FsT12125List = new HashSet<FsT12125List>();
            FsT20125List = new HashSet<FsT20125List>();
            FsT21125List = new HashSet<FsT21125List>();
            FsT31125List = new HashSet<FsT31125List>();
            FsT32125List = new HashSet<FsT32125List>();
            FsT33125List = new HashSet<FsT33125List>();
            FsT40125List = new HashSet<FsT40125List>();
            FsT41125List = new HashSet<FsT41125List>();
            FsT50125List = new HashSet<FsT50125List>();
            FsT51125List = new HashSet<FsT51125List>();
            FsT52125List = new HashSet<FsT52125List>();
            FsT701125List = new HashSet<FsT701125List>();
            FsT702125List = new HashSet<FsT702125List>();
            FsT708125List = new HashSet<FsT708125List>();
            FsT710125List = new HashSet<FsT710125List>();
        }

        public decimal Docid { get; set; }
        public decimal? Version { get; set; }
        public string TitlePartOrd { get; set; }
        public DateTime? TitlePartPrintDate { get; set; }
        public string TitlePartUnsealed { get; set; }
        public string TitlePartForm { get; set; }
        public string SePfnLeader { get; set; }
        public string SePfnChiefAcc { get; set; }
        public string SePfnLeaderOfFes { get; set; }
        public string SePfnPostLeader { get; set; }
        public string SePfnPostChiefAcc { get; set; }
        public string SePfnPostLeaderOf { get; set; }
        public string SePfnExecutor { get; set; }
        public string SePfnPostExecutor { get; set; }
        public string SePfnPhone { get; set; }
        public DateTime? Logid { get; set; }
        public string PrCodereportform { get; set; }

        public virtual ICollection<FsRepVnk125FoList> FsRepVnk125FoList { get; set; }
        public virtual ICollection<FsT01125List> FsT01125List { get; set; }
        public virtual ICollection<FsT10125List> FsT10125List { get; set; }
        public virtual ICollection<FsT11125List> FsT11125List { get; set; }
        public virtual ICollection<FsT12125List> FsT12125List { get; set; }
        public virtual ICollection<FsT20125List> FsT20125List { get; set; }
        public virtual ICollection<FsT21125List> FsT21125List { get; set; }
        public virtual ICollection<FsT31125List> FsT31125List { get; set; }
        public virtual ICollection<FsT32125List> FsT32125List { get; set; }
        public virtual ICollection<FsT33125List> FsT33125List { get; set; }
        public virtual ICollection<FsT40125List> FsT40125List { get; set; }
        public virtual ICollection<FsT41125List> FsT41125List { get; set; }
        public virtual ICollection<FsT50125List> FsT50125List { get; set; }
        public virtual ICollection<FsT51125List> FsT51125List { get; set; }
        public virtual ICollection<FsT52125List> FsT52125List { get; set; }
        public virtual ICollection<FsT701125List> FsT701125List { get; set; }
        public virtual ICollection<FsT702125List> FsT702125List { get; set; }
        public virtual ICollection<FsT708125List> FsT708125List { get; set; }
        public virtual ICollection<FsT710125List> FsT710125List { get; set; }
    }
}
