using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class DcArp2Report2
    {
        public DcArp2Report2()
        {
            FsTabArp2Rep2List = new HashSet<FsTabArp2Rep2List>();
        }

        public decimal Docid { get; set; }
        public decimal? Version { get; set; }
        public decimal? TtlC3R1 { get; set; }
        public decimal? TtlC4R1 { get; set; }
        public decimal? TtlC5R1 { get; set; }
        public decimal? TtlC6R1 { get; set; }

        public virtual ICollection<FsTabArp2Rep2List> FsTabArp2Rep2List { get; set; }
    }
}
