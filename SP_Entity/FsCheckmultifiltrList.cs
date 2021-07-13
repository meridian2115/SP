using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class FsCheckmultifiltrList
    {
        public FsCheckmultifiltrList()
        {
            FsCheckList = new HashSet<FsCheckList>();
            FsCheckcList = new HashSet<FsCheckcList>();
        }

        public decimal? Docid { get; set; }
        public decimal? Tablerownum { get; set; }
        public decimal Fieldsetid { get; set; }
        public string Nametable { get; set; }
        public string Contentrowtable { get; set; }

        public virtual DcCrSetT2 Doc { get; set; }
        public virtual ICollection<FsCheckList> FsCheckList { get; set; }
        public virtual ICollection<FsCheckcList> FsCheckcList { get; set; }
    }
}
