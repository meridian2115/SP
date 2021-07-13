using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class FsDictList
    {
        public FsDictList()
        {
            FsCondList = new HashSet<FsCondList>();
        }

        public decimal? Docid { get; set; }
        public decimal? Tablerownum { get; set; }
        public decimal Fieldsetid { get; set; }
        public string DataSetCode { get; set; }
        public string SourceName { get; set; }
        public string SourceCode { get; set; }
        public string SourceAlias { get; set; }
        public string SourceCodeExp { get; set; }

        public virtual DcArpSetBz Doc { get; set; }
        public virtual ICollection<FsCondList> FsCondList { get; set; }
    }
}
