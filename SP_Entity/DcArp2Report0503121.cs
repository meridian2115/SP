using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class DcArp2Report0503121
    {
        public DcArp2Report0503121()
        {
            FsBe05031212List = new HashSet<FsBe05031212List>();
            FsBr05031212List = new HashSet<FsBr05031212List>();
        }

        public decimal Docid { get; set; }
        public decimal? Version { get; set; }
        public decimal? C4R1 { get; set; }
        public decimal? C5R1 { get; set; }
        public decimal? C6R1 { get; set; }
        public decimal? C7R1 { get; set; }
        public decimal? C4R2 { get; set; }
        public decimal? C5R2 { get; set; }
        public decimal? C6R2 { get; set; }
        public decimal? C7R2 { get; set; }

        public virtual ICollection<FsBe05031212List> FsBe05031212List { get; set; }
        public virtual ICollection<FsBr05031212List> FsBr05031212List { get; set; }
    }
}
