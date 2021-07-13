using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class FsRcTab773aItogList
    {
        public decimal? Docid { get; set; }
        public decimal? Tablerownum { get; set; }
        public decimal Fieldsetid { get; set; }
        public string C1R2a1 { get; set; }
        public string C1R2b1 { get; set; }
        public string C1R2c1 { get; set; }
        public decimal? C2R2d1 { get; set; }

        public virtual DcReport0503773 Doc { get; set; }
    }
}
