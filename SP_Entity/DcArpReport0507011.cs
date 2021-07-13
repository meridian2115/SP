using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class DcArpReport0507011
    {
        public DcArpReport0507011()
        {
            FsBe1Tabr3011List = new HashSet<FsBe1Tabr3011List>();
            FsBe2Tabr4011List = new HashSet<FsBe2Tabr4011List>();
            FsBe3Tabr5011List = new HashSet<FsBe3Tabr5011List>();
            FsBe4Tabr6011List = new HashSet<FsBe4Tabr6011List>();
            FsBr1Tabr1011List = new HashSet<FsBr1Tabr1011List>();
            FsBr2Tabr2011List = new HashSet<FsBr2Tabr2011List>();
            FsSf1Tabr10011List = new HashSet<FsSf1Tabr10011List>();
            FsSf1Tabr7011List = new HashSet<FsSf1Tabr7011List>();
            FsSf1Tabr8011List = new HashSet<FsSf1Tabr8011List>();
            FsSf1Tabr9011List = new HashSet<FsSf1Tabr9011List>();
            FsSf2Tabr11011List = new HashSet<FsSf2Tabr11011List>();
            FsSf2Tabr12011List = new HashSet<FsSf2Tabr12011List>();
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
        public decimal? Br1C4R010 { get; set; }
        public decimal? Br2C4R010 { get; set; }
        public decimal? Be1C7R200 { get; set; }
        public decimal? Be1C8R200 { get; set; }
        public decimal? Be1C9R200 { get; set; }
        public decimal? Be1C10R200 { get; set; }
        public decimal? Be2C6R200 { get; set; }
        public decimal? Be2C7R200 { get; set; }
        public decimal? Be2C8R200 { get; set; }
        public decimal? Be2C9R200 { get; set; }
        public decimal? Be3C6R200 { get; set; }
        public decimal? Be3C7R200 { get; set; }
        public decimal? Be3C8R200 { get; set; }
        public decimal? Be3C9R200 { get; set; }
        public decimal? Be4C4R200 { get; set; }
        public decimal? Be4C5R200 { get; set; }
        public decimal? Be4C6R200 { get; set; }
        public decimal? Be4C7R200 { get; set; }
        public decimal? Be4C4R450 { get; set; }
        public decimal? Be4C5R450 { get; set; }
        public decimal? Be4C6R450 { get; set; }
        public decimal? Be4C7R450 { get; set; }
        public decimal? Sf1C4R500 { get; set; }
        public decimal? Sf1C5R500 { get; set; }
        public decimal? Sf1C6R500 { get; set; }
        public decimal? Sf1C7R500 { get; set; }
        public decimal? Sf1C4R520 { get; set; }
        public decimal? Sf1C5R520 { get; set; }
        public decimal? Sf1C6R520 { get; set; }
        public decimal? Sf1C7R520 { get; set; }
        public decimal? Sf1C4R620 { get; set; }
        public decimal? Sf1C5R620 { get; set; }
        public decimal? Sf1C6R620 { get; set; }
        public decimal? Sf1C7R620 { get; set; }
        public decimal? Sf1C4R700 { get; set; }
        public decimal? Sf1C5R700 { get; set; }
        public decimal? Sf1C6R700 { get; set; }
        public decimal? Sf1C7R700 { get; set; }
        public decimal? Sf1C4R710 { get; set; }
        public decimal? Sf1C5R710 { get; set; }
        public decimal? Sf1C6R710 { get; set; }
        public decimal? Sf1C7R710 { get; set; }
        public decimal? Sf1C4R720 { get; set; }
        public decimal? Sf1C5R720 { get; set; }
        public decimal? Sf1C6R720 { get; set; }
        public decimal? Sf1C7R720 { get; set; }
        public decimal? Sf2C5R500 { get; set; }
        public decimal? Sf2C6R500 { get; set; }
        public decimal? Sf2C7R500 { get; set; }
        public decimal? Sf2C8R500 { get; set; }
        public decimal? Sf2C5R520 { get; set; }
        public decimal? Sf2C6R520 { get; set; }
        public decimal? Sf2C7R520 { get; set; }
        public decimal? Sf2C8R520 { get; set; }
        public decimal? Sf2C5R620 { get; set; }
        public decimal? Sf2C6R620 { get; set; }
        public decimal? Sf2C7R620 { get; set; }
        public decimal? Sf2C8R620 { get; set; }
        public string TelIsp { get; set; }
        public decimal? Be1Year { get; set; }
        public decimal? Be2Year { get; set; }
        public decimal? Be3Year { get; set; }
        public decimal? Be4Year { get; set; }
        public decimal? Sf1Year { get; set; }
        public decimal? Sf2Year { get; set; }

        public virtual ICollection<FsBe1Tabr3011List> FsBe1Tabr3011List { get; set; }
        public virtual ICollection<FsBe2Tabr4011List> FsBe2Tabr4011List { get; set; }
        public virtual ICollection<FsBe3Tabr5011List> FsBe3Tabr5011List { get; set; }
        public virtual ICollection<FsBe4Tabr6011List> FsBe4Tabr6011List { get; set; }
        public virtual ICollection<FsBr1Tabr1011List> FsBr1Tabr1011List { get; set; }
        public virtual ICollection<FsBr2Tabr2011List> FsBr2Tabr2011List { get; set; }
        public virtual ICollection<FsSf1Tabr10011List> FsSf1Tabr10011List { get; set; }
        public virtual ICollection<FsSf1Tabr7011List> FsSf1Tabr7011List { get; set; }
        public virtual ICollection<FsSf1Tabr8011List> FsSf1Tabr8011List { get; set; }
        public virtual ICollection<FsSf1Tabr9011List> FsSf1Tabr9011List { get; set; }
        public virtual ICollection<FsSf2Tabr11011List> FsSf2Tabr11011List { get; set; }
        public virtual ICollection<FsSf2Tabr12011List> FsSf2Tabr12011List { get; set; }
    }
}
