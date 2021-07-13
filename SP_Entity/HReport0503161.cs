using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class HReport0503161
    {
        public HReport0503161()
        {
            HfsTableQtyinstnList = new HashSet<HfsTableQtyinstnList>();
        }

        public decimal Id { get; set; }
        public decimal? TtlqtyinstC2R2 { get; set; }
        public decimal? TtlqtyinstC4R2 { get; set; }
        public decimal? TtlqtyinstC5R2 { get; set; }
        public decimal? TtlqtyinstC6R2 { get; set; }
        public decimal? TtlqtyinstC7R2 { get; set; }
        public decimal? TtlqtyinstC8R2 { get; set; }
        public decimal? TtlqtyinstC9R2 { get; set; }
        public decimal? TtlqtyinstC10R2 { get; set; }
        public decimal? TtlqtyinstC11R2 { get; set; }
        public decimal? TtlqtyinstC12R2 { get; set; }
        public decimal? TtlqtyinstC13R2 { get; set; }
        public decimal? TtlqtyinstC14R2 { get; set; }
        public decimal? TtlqtyinstC15R2 { get; set; }

        public virtual ICollection<HfsTableQtyinstnList> HfsTableQtyinstnList { get; set; }
    }
}
