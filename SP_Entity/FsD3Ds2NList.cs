using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class FsD3Ds2NList
    {
        public decimal Fieldsetid { get; set; }
        public decimal? Tablerownum { get; set; }
        public decimal? FsD3SlListid { get; set; }
        public string Ds2 { get; set; }
        public bool? Ds2Pr { get; set; }
        public string PrDs2N { get; set; }

        public virtual FsD3SlList FsD3SlList { get; set; }
    }
}
