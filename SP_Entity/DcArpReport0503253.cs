using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class DcArpReport0503253
    {
        public DcArpReport0503253()
        {
            FsAdebtTable0201List = new HashSet<FsAdebtTable0201List>();
            FsAdebtTable0301List = new HashSet<FsAdebtTable0301List>();
            FsAdebtTable0401List = new HashSet<FsAdebtTable0401List>();
            FsAdebtTable0501List = new HashSet<FsAdebtTable0501List>();
            FsBdebtTable0201List = new HashSet<FsBdebtTable0201List>();
            FsBdebtTable0301List = new HashSet<FsBdebtTable0301List>();
            FsBdebtTable0401List = new HashSet<FsBdebtTable0401List>();
            FsBdebtTable0501List = new HashSet<FsBdebtTable0501List>();
        }

        public decimal Docid { get; set; }
        public decimal? Version { get; set; }
        public decimal? AdebtC4R010 { get; set; }
        public decimal? AdebtC5R010 { get; set; }
        public decimal? AdebtC6R010 { get; set; }
        public decimal? AdebtC7R010 { get; set; }
        public decimal? AdebtC8R010 { get; set; }
        public decimal? AdebtC9R010 { get; set; }
        public decimal? AdebtC10R010 { get; set; }
        public decimal? AdebtC11R010 { get; set; }
        public decimal? AdebtC12R010 { get; set; }
        public decimal? AdebtC13R010 { get; set; }
        public decimal? AdebtC4R020 { get; set; }
        public decimal? AdebtC5R020 { get; set; }
        public decimal? AdebtC6R020 { get; set; }
        public decimal? AdebtC7R020 { get; set; }
        public decimal? AdebtC8R020 { get; set; }
        public decimal? AdebtC9R020 { get; set; }
        public decimal? AdebtC10R020 { get; set; }
        public decimal? AdebtC11R020 { get; set; }
        public decimal? AdebtC12R020 { get; set; }
        public decimal? AdebtC13R020 { get; set; }
        public decimal? AdebtC4R030 { get; set; }
        public decimal? AdebtC5R030 { get; set; }
        public decimal? AdebtC6R030 { get; set; }
        public decimal? AdebtC7R030 { get; set; }
        public decimal? AdebtC8R030 { get; set; }
        public decimal? AdebtC9R030 { get; set; }
        public decimal? AdebtC10R030 { get; set; }
        public decimal? AdebtC11R030 { get; set; }
        public decimal? AdebtC12R030 { get; set; }
        public decimal? AdebtC13R030 { get; set; }
        public decimal? AdebtC4R040 { get; set; }
        public decimal? AdebtC5R040 { get; set; }
        public decimal? AdebtC6R040 { get; set; }
        public decimal? AdebtC7R040 { get; set; }
        public decimal? AdebtC8R040 { get; set; }
        public decimal? AdebtC9R040 { get; set; }
        public decimal? AdebtC10R040 { get; set; }
        public decimal? AdebtC11R040 { get; set; }
        public decimal? AdebtC12R040 { get; set; }
        public decimal? AdebtC13R040 { get; set; }
        public decimal? AdebtC4R050 { get; set; }
        public decimal? AdebtC5R050 { get; set; }
        public decimal? AdebtC6R050 { get; set; }
        public decimal? AdebtC7R050 { get; set; }
        public decimal? AdebtC8R050 { get; set; }
        public decimal? AdebtC9R050 { get; set; }
        public decimal? AdebtC10R050 { get; set; }
        public decimal? AdebtC11R050 { get; set; }
        public decimal? AdebtC12R050 { get; set; }
        public decimal? AdebtC13R050 { get; set; }
        public decimal? AdebtC4R060 { get; set; }
        public decimal? AdebtC5R060 { get; set; }
        public decimal? AdebtC6R060 { get; set; }
        public decimal? AdebtC7R060 { get; set; }
        public decimal? AdebtC8R060 { get; set; }
        public decimal? AdebtC9R060 { get; set; }
        public decimal? AdebtC10R060 { get; set; }
        public decimal? AdebtC11R060 { get; set; }
        public decimal? AdebtC12R060 { get; set; }
        public decimal? AdebtC13R060 { get; set; }
        public decimal? BdebtC4R010 { get; set; }
        public decimal? BdebtC4R020 { get; set; }
        public decimal? BdebtC4R030 { get; set; }
        public decimal? BdebtC4R040 { get; set; }
        public decimal? BdebtC4R050 { get; set; }
        public string Surrogat { get; set; }
        public string Ord { get; set; }
        public string Namtip { get; set; }
        public string Subotch { get; set; }
        public string PfnLeader { get; set; }
        public string PfnChiefAcc { get; set; }
        public string PfnLeaderOfFes { get; set; }
        public string PfnPostLeader { get; set; }
        public string PfnPostChiefAcc { get; set; }
        public string PfnPostLeaderOf { get; set; }
        public string PfnExecutor { get; set; }
        public string PfnPostExecutor { get; set; }
        public string PfnPhone { get; set; }
        public string CaExecutor { get; set; }
        public string PostCaExecutor { get; set; }

        public virtual ICollection<FsAdebtTable0201List> FsAdebtTable0201List { get; set; }
        public virtual ICollection<FsAdebtTable0301List> FsAdebtTable0301List { get; set; }
        public virtual ICollection<FsAdebtTable0401List> FsAdebtTable0401List { get; set; }
        public virtual ICollection<FsAdebtTable0501List> FsAdebtTable0501List { get; set; }
        public virtual ICollection<FsBdebtTable0201List> FsBdebtTable0201List { get; set; }
        public virtual ICollection<FsBdebtTable0301List> FsBdebtTable0301List { get; set; }
        public virtual ICollection<FsBdebtTable0401List> FsBdebtTable0401List { get; set; }
        public virtual ICollection<FsBdebtTable0501List> FsBdebtTable0501List { get; set; }
    }
}
