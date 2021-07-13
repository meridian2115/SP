using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class FsD1SlKoefList
    {
        public decimal Fieldsetid { get; set; }
        public decimal? Tablerownum { get; set; }
        public decimal? FsD1KsgKpgListid { get; set; }
        public string Idsl { get; set; }
        public decimal? ZSl { get; set; }

        public virtual FsD1KsgKpgList FsD1KsgKpgList { get; set; }
    }
}
