using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class FsR1T1128fList
    {
        public FsR1T1128fList()
        {
            FsT2128fList = new HashSet<FsT2128fList>();
        }

        public decimal? Docid { get; set; }
        public decimal? Tablerownum { get; set; }
        public decimal Fieldsetid { get; set; }
        public string NumR1T1 { get; set; }
        public string C1R1T1 { get; set; }
        public string C2R1T1 { get; set; }
        public string C3R1T1 { get; set; }
        public string C4R1T1 { get; set; }
        public string C5R1T1 { get; set; }
        public string C6R1T1 { get; set; }
        public string C6aR1T1 { get; set; }
        public string C6bR1T1 { get; set; }
        public string C6cR1T1 { get; set; }
        public string C6dR1T1 { get; set; }
        public decimal? C7R1T1 { get; set; }
        public decimal? C8R1T1 { get; set; }
        public decimal? C81R1T1 { get; set; }
        public decimal? C82R1T1 { get; set; }
        public string C9R1T1 { get; set; }
        public string CountT2 { get; set; }
        public decimal? Docid1 { get; set; }

        public virtual DcArpReport0503128Faip Doc { get; set; }
        public virtual ICollection<FsT2128fList> FsT2128fList { get; set; }
    }
}
