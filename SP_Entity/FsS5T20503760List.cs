using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class FsS5T20503760List
    {
        public decimal? Docid { get; set; }
        public decimal? Tablerownum { get; set; }
        public decimal Fieldsetid { get; set; }
        public string C1R11 { get; set; }
        public string C2R11 { get; set; }
        public string C2R11b { get; set; }
        public string C2R11c { get; set; }
        public string C3R11 { get; set; }
        public string C4R11 { get; set; }
        public string PlanAcc { get; set; }

        public virtual DcReport0503760T4 Doc { get; set; }
    }
}
