using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class FsR1T1324TestList
    {
        public FsR1T1324TestList()
        {
            FsT2324TestList = new HashSet<FsT2324TestList>();
        }

        public decimal? Docid { get; set; }
        public decimal? Tablerownum { get; set; }
        public decimal Fieldsetid { get; set; }
        public string NumR1T1 { get; set; }
        public string C1R1T1 { get; set; }
        public string C2R1T1 { get; set; }
        public string C3R1T1 { get; set; }
        public string C4R1T1 { get; set; }
        public string C4aR1T1 { get; set; }
        public string C4bR1T1 { get; set; }
        public decimal? C5R1T1 { get; set; }
        public decimal? C6R1T1 { get; set; }
        public decimal? C7R1T1 { get; set; }
        public decimal? C8R1T1 { get; set; }
        public decimal? C9R1T1 { get; set; }
        public decimal? C10R1T1 { get; set; }
        public decimal? C11R1T1 { get; set; }
        public decimal? C12R1T1 { get; set; }
        public decimal? C13R1T1 { get; set; }
        public string CountT2 { get; set; }
        public decimal? Docid1 { get; set; }

        public virtual DcReportTest Doc { get; set; }
        public virtual ICollection<FsT2324TestList> FsT2324TestList { get; set; }
    }
}
