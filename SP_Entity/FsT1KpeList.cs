using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class FsT1KpeList
    {
        public FsT1KpeList()
        {
            FsT2KpeList = new HashSet<FsT2KpeList>();
        }

        public decimal? Docid { get; set; }
        public decimal? Tablerownum { get; set; }
        public decimal Fieldsetid { get; set; }
        public string C1T1 { get; set; }
        public string C2T1 { get; set; }
        public decimal? C7T1 { get; set; }
        public decimal? C8T1 { get; set; }

        public virtual DcSpKpe Doc { get; set; }
        public virtual ICollection<FsT2KpeList> FsT2KpeList { get; set; }
    }
}
