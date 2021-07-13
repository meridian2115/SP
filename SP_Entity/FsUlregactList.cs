using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class FsUlregactList
    {
        public decimal? Docid { get; set; }
        public decimal? Tablerownum { get; set; }
        public decimal Fieldsetid { get; set; }
        public DateTime? Dtzap { get; set; }
        public string Grn { get; set; }
        public string Idzap { get; set; }
        public string Vidregid { get; set; }
        public string Vidregname { get; set; }
        public string Regorgid { get; set; }
        public string Regorgname { get; set; }

        public virtual DcRefEgrul Doc { get; set; }
    }
}
