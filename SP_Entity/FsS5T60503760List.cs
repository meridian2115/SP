using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class FsS5T60503760List
    {
        public decimal? Docid { get; set; }
        public decimal? Tablerownum { get; set; }
        public decimal Fieldsetid { get; set; }
        public string C1R11 { get; set; }
        public DateTime? C2R11 { get; set; }
        public string C3R11 { get; set; }
        public DateTime? C4R11 { get; set; }
        public string C5R11 { get; set; }
        public string C5R11b { get; set; }
        public string C5R11c { get; set; }
        public decimal? C6R11 { get; set; }
        public string C7R11 { get; set; }
        public string PlanAcc { get; set; }

        public virtual DcReport0503760T6 Doc { get; set; }
    }
}
