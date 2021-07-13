using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class DcRpPrt0503127
    {
        public DcRpPrt0503127()
        {
            FsRepVnk127grbsList = new HashSet<FsRepVnk127grbsList>();
            FsVnk127GrbsT01List = new HashSet<FsVnk127GrbsT01List>();
            FsVnk127GrbsT02List = new HashSet<FsVnk127GrbsT02List>();
            FsVnk127GrbsT03List = new HashSet<FsVnk127GrbsT03List>();
            FsVnk127GrbsT04List = new HashSet<FsVnk127GrbsT04List>();
            FsVnk127GrbsT05List = new HashSet<FsVnk127GrbsT05List>();
            FsVnk127GrbsT06List = new HashSet<FsVnk127GrbsT06List>();
            FsVnk127GrbsT07List = new HashSet<FsVnk127GrbsT07List>();
            FsVnk127GrbsT08List = new HashSet<FsVnk127GrbsT08List>();
            FsVnk127GrbsT09List = new HashSet<FsVnk127GrbsT09List>();
            FsVnk127GrbsT10List = new HashSet<FsVnk127GrbsT10List>();
            FsVnk127GrbsT11List = new HashSet<FsVnk127GrbsT11List>();
            FsVnk127GrbsT12List = new HashSet<FsVnk127GrbsT12List>();
            FsVnk127GrbsT13List = new HashSet<FsVnk127GrbsT13List>();
            FsVnk127GrbsT14List = new HashSet<FsVnk127GrbsT14List>();
            FsVnk127GrbsT15List = new HashSet<FsVnk127GrbsT15List>();
            FsVnk127GrbsT16List = new HashSet<FsVnk127GrbsT16List>();
            FsVnk127GrbsT17List = new HashSet<FsVnk127GrbsT17List>();
            FsVnk127GrbsT18List = new HashSet<FsVnk127GrbsT18List>();
            FsVnk127GrbsT19List = new HashSet<FsVnk127GrbsT19List>();
            FsVnk127GrbsT20List = new HashSet<FsVnk127GrbsT20List>();
            FsVnk127GrbsT21List = new HashSet<FsVnk127GrbsT21List>();
            FsVnk127GrbsT22List = new HashSet<FsVnk127GrbsT22List>();
        }

        public decimal Docid { get; set; }
        public decimal? Version { get; set; }
        public string Ord { get; set; }
        public string SePfnLeader { get; set; }
        public string SePfnChiefAcc { get; set; }
        public string SePfnLeaderOfFes { get; set; }
        public string SePfnPostLeader { get; set; }
        public string SePfnPostChiefAcc { get; set; }
        public string SePfnPostLeaderOf { get; set; }
        public string SePfnExecutor { get; set; }
        public string SePfnPostExecutor { get; set; }
        public string SePfnPhone { get; set; }
        public string Surrogat { get; set; }
        public DateTime? Logid { get; set; }
        public string PrCodereportform { get; set; }

        public virtual ICollection<FsRepVnk127grbsList> FsRepVnk127grbsList { get; set; }
        public virtual ICollection<FsVnk127GrbsT01List> FsVnk127GrbsT01List { get; set; }
        public virtual ICollection<FsVnk127GrbsT02List> FsVnk127GrbsT02List { get; set; }
        public virtual ICollection<FsVnk127GrbsT03List> FsVnk127GrbsT03List { get; set; }
        public virtual ICollection<FsVnk127GrbsT04List> FsVnk127GrbsT04List { get; set; }
        public virtual ICollection<FsVnk127GrbsT05List> FsVnk127GrbsT05List { get; set; }
        public virtual ICollection<FsVnk127GrbsT06List> FsVnk127GrbsT06List { get; set; }
        public virtual ICollection<FsVnk127GrbsT07List> FsVnk127GrbsT07List { get; set; }
        public virtual ICollection<FsVnk127GrbsT08List> FsVnk127GrbsT08List { get; set; }
        public virtual ICollection<FsVnk127GrbsT09List> FsVnk127GrbsT09List { get; set; }
        public virtual ICollection<FsVnk127GrbsT10List> FsVnk127GrbsT10List { get; set; }
        public virtual ICollection<FsVnk127GrbsT11List> FsVnk127GrbsT11List { get; set; }
        public virtual ICollection<FsVnk127GrbsT12List> FsVnk127GrbsT12List { get; set; }
        public virtual ICollection<FsVnk127GrbsT13List> FsVnk127GrbsT13List { get; set; }
        public virtual ICollection<FsVnk127GrbsT14List> FsVnk127GrbsT14List { get; set; }
        public virtual ICollection<FsVnk127GrbsT15List> FsVnk127GrbsT15List { get; set; }
        public virtual ICollection<FsVnk127GrbsT16List> FsVnk127GrbsT16List { get; set; }
        public virtual ICollection<FsVnk127GrbsT17List> FsVnk127GrbsT17List { get; set; }
        public virtual ICollection<FsVnk127GrbsT18List> FsVnk127GrbsT18List { get; set; }
        public virtual ICollection<FsVnk127GrbsT19List> FsVnk127GrbsT19List { get; set; }
        public virtual ICollection<FsVnk127GrbsT20List> FsVnk127GrbsT20List { get; set; }
        public virtual ICollection<FsVnk127GrbsT21List> FsVnk127GrbsT21List { get; set; }
        public virtual ICollection<FsVnk127GrbsT22List> FsVnk127GrbsT22List { get; set; }
    }
}
