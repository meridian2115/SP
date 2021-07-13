using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class DcDbdOperinfofbexp
    {
        public DcDbdOperinfofbexp()
        {
            FsDbdOifbeSummaryList = new HashSet<FsDbdOifbeSummaryList>();
        }

        public decimal Docid { get; set; }
        public decimal? Version { get; set; }
        public DateTime? Finyear { get; set; }
        public decimal? TpSt3S { get; set; }
        public decimal? TpSt4S { get; set; }
        public decimal? TpSt5S { get; set; }
        public decimal? TpSt6S { get; set; }
        public decimal? TpSt7S { get; set; }

        public virtual ICollection<FsDbdOifbeSummaryList> FsDbdOifbeSummaryList { get; set; }
    }
}
