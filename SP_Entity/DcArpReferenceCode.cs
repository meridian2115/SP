using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class DcArpReferenceCode
    {
        public DcArpReferenceCode()
        {
            FsRcKosguList = new HashSet<FsRcKosguList>();
            FsRcKvfodList = new HashSet<FsRcKvfodList>();
        }

        public decimal Docid { get; set; }
        public decimal? Version { get; set; }
        public DateTime? DataStartactive { get; set; }
        public DateTime? DataEndactive { get; set; }
        public string Type { get; set; }
        public string Account { get; set; }
        public string Ac { get; set; }
        public string Kosgu { get; set; }
        public string Kvfo { get; set; }
        public string Note { get; set; }

        public virtual ICollection<FsRcKosguList> FsRcKosguList { get; set; }
        public virtual ICollection<FsRcKvfodList> FsRcKvfodList { get; set; }
    }
}
