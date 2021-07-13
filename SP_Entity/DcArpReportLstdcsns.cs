using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class DcArpReportLstdcsns
    {
        public DcArpReportLstdcsns()
        {
            FsTabR1List = new HashSet<FsTabR1List>();
            FsTabR2List = new HashSet<FsTabR2List>();
            FsTabR3List = new HashSet<FsTabR3List>();
        }

        public decimal Docid { get; set; }
        public decimal? Version { get; set; }
        public string Ord { get; set; }

        public virtual ICollection<FsTabR1List> FsTabR1List { get; set; }
        public virtual ICollection<FsTabR2List> FsTabR2List { get; set; }
        public virtual ICollection<FsTabR3List> FsTabR3List { get; set; }
    }
}
