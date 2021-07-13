using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class FsT4324List
    {
        public decimal Fieldsetid { get; set; }
        public decimal? Tablerownum { get; set; }
        public decimal? FsR2T1324Listid { get; set; }
        public string NumR2T2 { get; set; }
        public string C1R2T2 { get; set; }
        public string C2R2T2 { get; set; }
        public string C3R2T2 { get; set; }
        public string C3aR2T2 { get; set; }
        public string C3bR2T2 { get; set; }
        public string C3cR2T2 { get; set; }
        public string C3dR2T2 { get; set; }
        public decimal? C4R2T2 { get; set; }
        public decimal? Docid { get; set; }

        public virtual FsR2T1324List FsR2T1324List { get; set; }
    }
}
