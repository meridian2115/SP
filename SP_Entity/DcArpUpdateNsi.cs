using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class DcArpUpdateNsi
    {
        public DcArpUpdateNsi()
        {
            FsNsiList = new HashSet<FsNsiList>();
        }

        public decimal Docid { get; set; }
        public decimal? Version { get; set; }
        public bool? Tech { get; set; }
        public string Cd { get; set; }

        public virtual ICollection<FsNsiList> FsNsiList { get; set; }
    }
}
