using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class DcArpSoa0504833
    {
        public DcArpSoa0504833()
        {
            FsSoa0504833List = new HashSet<FsSoa0504833List>();
            FsSoa0504833SubList = new HashSet<FsSoa0504833SubList>();
        }

        public decimal Docid { get; set; }
        public decimal? Version { get; set; }
        public DateTime? Createdate { get; set; }
        public string Npp { get; set; }

        public virtual ICollection<FsSoa0504833List> FsSoa0504833List { get; set; }
        public virtual ICollection<FsSoa0504833SubList> FsSoa0504833SubList { get; set; }
    }
}
