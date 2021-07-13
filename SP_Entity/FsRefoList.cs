using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class FsRefoList
    {
        public decimal? Docid { get; set; }
        public decimal? Tablerownum { get; set; }
        public decimal Fieldsetid { get; set; }
        public string SysForm { get; set; }
        public string SysName { get; set; }
        public string Okud { get; set; }
        public string Ar { get; set; }
        public string Ksbu { get; set; }
        public string Syscd { get; set; }
        public string Numstr { get; set; }

        public virtual DcArpSoglas Doc { get; set; }
    }
}
