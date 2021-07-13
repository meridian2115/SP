using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class FsR2T3324TestList
    {
        public FsR2T3324TestList()
        {
            FsT4324TestList = new HashSet<FsT4324TestList>();
        }

        public decimal? Docid { get; set; }
        public decimal? Tablerownum { get; set; }
        public decimal Fieldsetid { get; set; }
        public string NumR2T1 { get; set; }
        public string C1R2T1 { get; set; }
        public string C2R2T1 { get; set; }
        public string C3R2T1 { get; set; }
        public string C3aR2T1 { get; set; }
        public string C3bR2T1 { get; set; }
        public string C3cR2T1 { get; set; }
        public string C3dR2T1 { get; set; }
        public decimal? C4R2T1 { get; set; }
        public string CountT4 { get; set; }

        public virtual DcReportTest Doc { get; set; }
        public virtual ICollection<FsT4324TestList> FsT4324TestList { get; set; }
    }
}
