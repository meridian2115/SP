using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class DcSpKpe
    {
        public DcSpKpe()
        {
            FsT1KpeList = new HashSet<FsT1KpeList>();
        }

        public decimal Docid { get; set; }
        public decimal? Version { get; set; }
        public string Periodicity { get; set; }
        public decimal? C7R1 { get; set; }
        public decimal? C8R1 { get; set; }
        public string NameForm { get; set; }
        public string NameDop { get; set; }

        public virtual ICollection<FsT1KpeList> FsT1KpeList { get; set; }
    }
}
