using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class FsD2SankList
    {
        public decimal Fieldsetid { get; set; }
        public decimal? Tablerownum { get; set; }
        public decimal? FsD2ZSlListid { get; set; }
        public string SCode { get; set; }
        public decimal? SSum { get; set; }
        public string STip { get; set; }
        public string SlId { get; set; }
        public string SOsn { get; set; }
        public DateTime? DateAct { get; set; }
        public string NumAct { get; set; }
        public string CodeExp { get; set; }
        public string SCom { get; set; }
        public string SIst { get; set; }

        public virtual FsD2ZSlList FsD2ZSlList { get; set; }
    }
}
