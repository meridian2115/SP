using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class FsD3NazList
    {
        public decimal Fieldsetid { get; set; }
        public decimal? Tablerownum { get; set; }
        public decimal? FsD3SlListid { get; set; }
        public string NazN { get; set; }
        public string NazR { get; set; }
        public string NazSp { get; set; }
        public string NazV { get; set; }
        public string NazUsl { get; set; }
        public DateTime? NaprDate { get; set; }
        public string NaprMo { get; set; }
        public string NazPmp { get; set; }
        public string NazPk { get; set; }

        public virtual FsD3SlList FsD3SlList { get; set; }
    }
}
