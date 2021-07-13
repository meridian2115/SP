using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class FsR3T5324TestList
    {
        public decimal? Docid { get; set; }
        public decimal? Tablerownum { get; set; }
        public decimal Fieldsetid { get; set; }
        public string NumR3T1 { get; set; }
        public string LncdR3T1 { get; set; }
        public string C1R3T1 { get; set; }
        public string C2R3T1 { get; set; }
        public string C3R3T1 { get; set; }
        public decimal? C4R3T1 { get; set; }
        public string C5R3T1 { get; set; }
        public string C6R3T1 { get; set; }

        public virtual DcReportTest Doc { get; set; }
    }
}
