using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class DcArpReport0503160T4
    {
        public DcArpReport0503160T4()
        {
            FsR10503160T4List = new HashSet<FsR10503160T4List>();
        }

        public decimal Docid { get; set; }
        public decimal? Version { get; set; }
        public string Ord { get; set; }

        public virtual ICollection<FsR10503160T4List> FsR10503160T4List { get; set; }
    }
}
