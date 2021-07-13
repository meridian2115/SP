using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class DcArpReportFinSub
    {
        public DcArpReportFinSub()
        {
            FsFinSubTab100List = new HashSet<FsFinSubTab100List>();
            FsFinSubTab1List = new HashSet<FsFinSubTab1List>();
            FsFinSubTab200List = new HashSet<FsFinSubTab200List>();
            FsFinSubTabprintList = new HashSet<FsFinSubTabprintList>();
        }

        public decimal Docid { get; set; }
        public decimal? Version { get; set; }
        public string Ord { get; set; }
        public string TotalR100 { get; set; }

        public virtual ICollection<FsFinSubTab100List> FsFinSubTab100List { get; set; }
        public virtual ICollection<FsFinSubTab1List> FsFinSubTab1List { get; set; }
        public virtual ICollection<FsFinSubTab200List> FsFinSubTab200List { get; set; }
        public virtual ICollection<FsFinSubTabprintList> FsFinSubTabprintList { get; set; }
    }
}
