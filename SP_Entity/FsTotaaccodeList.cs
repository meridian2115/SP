using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class FsTotaaccodeList
    {
        public decimal? Docid { get; set; }
        public decimal? Tablerownum { get; set; }
        public decimal Fieldsetid { get; set; }
        public string C1cR01020 { get; set; }
        public string C1dR01020 { get; set; }
        public decimal? C2R01020 { get; set; }

        public virtual DcReport0503771 Doc { get; set; }
    }
}
