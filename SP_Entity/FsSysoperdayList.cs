using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class FsSysoperdayList
    {
        public decimal? Docid { get; set; }
        public decimal? Tablerownum { get; set; }
        public decimal Fieldsetid { get; set; }
        public string Stat { get; set; }
        public DateTime? Day { get; set; }
        public DateTime? DataStartactive { get; set; }
        public DateTime? DataEndactive { get; set; }
        public string ErrProc { get; set; }
        public string State { get; set; }
        public string Tofk { get; set; }
        public string Tfield { get; set; }
        public string TofkHidden { get; set; }
        public string SysStatusName { get; set; }
        public string TReopenTofk { get; set; }

        public virtual DcArpFahOperday Doc { get; set; }
    }
}
