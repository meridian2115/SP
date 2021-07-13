using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class HArpReport0503128
    {
        public HArpReport0503128()
        {
            HfsExpT10503128List = new HashSet<HfsExpT10503128List>();
            HfsSfT20503128List = new HashSet<HfsSfT20503128List>();
        }

        public decimal Id { get; set; }
        public decimal? ExpC4R200 { get; set; }
        public decimal? ExpC5R200 { get; set; }
        public decimal? ExpC6R200 { get; set; }
        public decimal? ExpC7R200 { get; set; }
        public decimal? ExpC8R200 { get; set; }
        public decimal? ExpC9R200 { get; set; }
        public decimal? ExpC10R200 { get; set; }
        public decimal? ExpC11R200 { get; set; }
        public decimal? ExpC12R200 { get; set; }
        public decimal? SfC4R510 { get; set; }
        public decimal? SfC5R510 { get; set; }
        public decimal? SfC6R510 { get; set; }
        public decimal? SfC7R510 { get; set; }
        public decimal? SfC8R510 { get; set; }
        public decimal? SfC9R510 { get; set; }
        public decimal? SfC10R510 { get; set; }
        public decimal? SfC11R510 { get; set; }
        public decimal? SfC12R510 { get; set; }
        public decimal? CfC4R900 { get; set; }
        public decimal? CfC5R900 { get; set; }
        public decimal? CfC6R900 { get; set; }
        public decimal? CfC7R900 { get; set; }
        public decimal? CfC8R900 { get; set; }
        public decimal? CfC9R900 { get; set; }
        public decimal? CfC10R900 { get; set; }
        public decimal? CfC11R900 { get; set; }
        public decimal? CfC12R900 { get; set; }
        public decimal? CfC4R910 { get; set; }
        public decimal? CfC5R910 { get; set; }
        public decimal? CfC6R910 { get; set; }
        public decimal? CfC7R910 { get; set; }
        public decimal? CfC8R910 { get; set; }
        public decimal? CfC9R910 { get; set; }
        public decimal? CfC10R910 { get; set; }
        public decimal? CfC11R910 { get; set; }
        public decimal? CfC12R910 { get; set; }
        public decimal? CfC4R920 { get; set; }
        public decimal? CfC5R920 { get; set; }
        public decimal? CfC6R920 { get; set; }
        public decimal? CfC7R920 { get; set; }
        public decimal? CfC8R920 { get; set; }
        public decimal? CfC9R920 { get; set; }
        public decimal? CfC10R920 { get; set; }
        public decimal? CfC11R920 { get; set; }
        public decimal? CfC12R920 { get; set; }
        public decimal? CfC4R999 { get; set; }
        public decimal? CfC5R999 { get; set; }
        public decimal? CfC6R999 { get; set; }
        public decimal? CfC7R999 { get; set; }
        public decimal? CfC8R999 { get; set; }
        public decimal? CfC9R999 { get; set; }
        public decimal? CfC10R999 { get; set; }
        public decimal? CfC11R999 { get; set; }
        public decimal? CfC12R999 { get; set; }
        public decimal? CfC4R911 { get; set; }
        public decimal? CfC5R911 { get; set; }
        public decimal? CfC6R911 { get; set; }
        public decimal? CfC7R911 { get; set; }
        public decimal? CfC8R911 { get; set; }
        public decimal? CfC9R911 { get; set; }
        public decimal? CfC10R911 { get; set; }
        public decimal? CfC11R911 { get; set; }
        public decimal? CfC12R911 { get; set; }

        public virtual ICollection<HfsExpT10503128List> HfsExpT10503128List { get; set; }
        public virtual ICollection<HfsSfT20503128List> HfsSfT20503128List { get; set; }
    }
}
