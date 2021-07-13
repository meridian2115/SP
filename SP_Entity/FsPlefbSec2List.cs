using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class FsPlefbSec2List
    {
        public decimal? Docid { get; set; }
        public decimal? Tablerownum { get; set; }
        public decimal Fieldsetid { get; set; }
        public string Nameindex { get; set; }
        public decimal? Cashexec { get; set; }
        public string KbkAp { get; set; }
        public string KbkDohfb { get; set; }
        public string Kbk { get; set; }

        public virtual DcArpProjectLawExecFb Doc { get; set; }
    }
}
