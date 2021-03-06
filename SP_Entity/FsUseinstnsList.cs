using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class FsUseinstnsList
    {
        public decimal? Docid { get; set; }
        public decimal? Tablerownum { get; set; }
        public decimal Fieldsetid { get; set; }
        public string InstnNm { get; set; }
        public string InstnCd { get; set; }
        public string InstnCdguid { get; set; }

        public virtual DcRefCsie Doc { get; set; }
    }
}
