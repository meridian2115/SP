using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class DcRefLists
    {
        public DcRefLists()
        {
            FsValsList = new HashSet<FsValsList>();
        }

        public decimal Docid { get; set; }
        public decimal? Version { get; set; }
        public string Listnm { get; set; }
        public string Note { get; set; }
        public DateTime? DataStartactive { get; set; }
        public DateTime? DataEndactive { get; set; }
        public DateTime? Startactivepf { get; set; }
        public DateTime? Endactivepf { get; set; }

        public virtual ICollection<FsValsList> FsValsList { get; set; }
    }
}
