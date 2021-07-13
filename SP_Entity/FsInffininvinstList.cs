using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class FsInffininvinstList
    {
        public decimal? Docid { get; set; }
        public decimal? Tablerownum { get; set; }
        public decimal Fieldsetid { get; set; }
        public string C1aR01030 { get; set; }
        public string C1bR01030 { get; set; }
        public string C1b1R01030 { get; set; }
        public string C1b2R01030 { get; set; }
        public string C1b3R01030 { get; set; }
        public string C1cR01030 { get; set; }
        public string C1dR01030 { get; set; }
        public string C1eR01030 { get; set; }
        public decimal? C2R01030 { get; set; }
        public string C3R01030 { get; set; }
        public string C4R01030 { get; set; }
        public string C5aR01030 { get; set; }
        public string C5bR01030 { get; set; }
        public string C5cR01030 { get; set; }
        public string C6R01030 { get; set; }
        public string PlanAcc { get; set; }
        public string Inn { get; set; }

        public virtual DcReport0503771 Doc { get; set; }
    }
}
