using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class FsD4ConsList
    {
        public decimal Fieldsetid { get; set; }
        public decimal? Tablerownum { get; set; }
        public decimal? FsD4SlListid { get; set; }
        public string PrCons { get; set; }
        public DateTime? DtCons { get; set; }

        public virtual FsD4SlList FsD4SlList { get; set; }
    }
}
