using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class DcRefAnltoba
    {
        public DcRefAnltoba()
        {
            FsAnlList = new HashSet<FsAnlList>();
        }

        public decimal Docid { get; set; }
        public decimal? Version { get; set; }
        public string InstCdinst { get; set; }
        public string InstNminst { get; set; }
        public string AccountCdacc { get; set; }
        public string AccountNmacc { get; set; }
        public string Note { get; set; }
        public DateTime? DataStartactive { get; set; }
        public DateTime? DataEndactive { get; set; }

        public virtual ICollection<FsAnlList> FsAnlList { get; set; }
    }
}
