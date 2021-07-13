using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class DcDictAccls
    {
        public DcDictAccls()
        {
            FsLsList = new HashSet<FsLsList>();
        }

        public decimal Docid { get; set; }
        public decimal? Version { get; set; }
        public string Numberpp { get; set; }
        public string Nameasfk { get; set; }
        public string Nameoebs { get; set; }
        public string Setcreating { get; set; }
        public string Fullname { get; set; }
        public string Codeform { get; set; }
        public string Lscode { get; set; }
        public DateTime? DataStartactive { get; set; }
        public DateTime? DataEndactive { get; set; }
        public string Note { get; set; }

        public virtual ICollection<FsLsList> FsLsList { get; set; }
    }
}
