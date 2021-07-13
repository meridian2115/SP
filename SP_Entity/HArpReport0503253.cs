using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class HArpReport0503253
    {
        public HArpReport0503253()
        {
            HfsAdebtTable0201List = new HashSet<HfsAdebtTable0201List>();
            HfsAdebtTable0301List = new HashSet<HfsAdebtTable0301List>();
            HfsAdebtTable0401List = new HashSet<HfsAdebtTable0401List>();
            HfsAdebtTable0501List = new HashSet<HfsAdebtTable0501List>();
            HfsBdebtTable0201List = new HashSet<HfsBdebtTable0201List>();
            HfsBdebtTable0301List = new HashSet<HfsBdebtTable0301List>();
            HfsBdebtTable0401List = new HashSet<HfsBdebtTable0401List>();
            HfsBdebtTable0501List = new HashSet<HfsBdebtTable0501List>();
        }

        public decimal Id { get; set; }
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

        public virtual ICollection<HfsAdebtTable0201List> HfsAdebtTable0201List { get; set; }
        public virtual ICollection<HfsAdebtTable0301List> HfsAdebtTable0301List { get; set; }
        public virtual ICollection<HfsAdebtTable0401List> HfsAdebtTable0401List { get; set; }
        public virtual ICollection<HfsAdebtTable0501List> HfsAdebtTable0501List { get; set; }
        public virtual ICollection<HfsBdebtTable0201List> HfsBdebtTable0201List { get; set; }
        public virtual ICollection<HfsBdebtTable0301List> HfsBdebtTable0301List { get; set; }
        public virtual ICollection<HfsBdebtTable0401List> HfsBdebtTable0401List { get; set; }
        public virtual ICollection<HfsBdebtTable0501List> HfsBdebtTable0501List { get; set; }
    }
}
