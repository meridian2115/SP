using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class FsActDet0503121List
    {
        public decimal Fieldsetid { get; set; }
        public decimal? Tablerownum { get; set; }
        public decimal? FsAct0503121Listid { get; set; }
        public string C1R3 { get; set; }
        public string C2R3 { get; set; }
        public string C3R3 { get; set; }
        public decimal? C4R3 { get; set; }
        public decimal? C5R3 { get; set; }
        public decimal? C6R3 { get; set; }

        public virtual FsAct0503121List FsAct0503121List { get; set; }
    }
}
