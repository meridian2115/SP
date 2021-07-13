using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class FsS1T10503760List
    {
        public decimal? Docid { get; set; }
        public decimal? Tablerownum { get; set; }
        public decimal Fieldsetid { get; set; }
        public string C1R11 { get; set; }
        public string C2R11 { get; set; }
        public string C3R11 { get; set; }

        public virtual DcReport0503760T1 Doc { get; set; }
    }
}
