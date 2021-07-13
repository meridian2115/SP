using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class DcSourcesRpCalc
    {
        public DcSourcesRpCalc()
        {
            FsFieldBuList = new HashSet<FsFieldBuList>();
        }

        public decimal Docid { get; set; }
        public decimal? Version { get; set; }
        public string Numpp { get; set; }
        public string SourceType { get; set; }
        public string SourceName { get; set; }
        public string SourceCode { get; set; }
        public string SourceAlias { get; set; }

        public virtual ICollection<FsFieldBuList> FsFieldBuList { get; set; }
    }
}
