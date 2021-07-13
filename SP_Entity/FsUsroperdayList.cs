using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class FsUsroperdayList
    {
        public decimal? Docid { get; set; }
        public decimal? Tablerownum { get; set; }
        public decimal Fieldsetid { get; set; }
        public string State { get; set; }
        public string Rfp { get; set; }
        public string Inst { get; set; }
        public string Login { get; set; }
        public string Usr { get; set; }
        public string Crnt { get; set; }
        public DateTime? DataStartactive { get; set; }
        public DateTime? DataEndactive { get; set; }
        public string Instcd { get; set; }
        public string Dept { get; set; }

        public virtual DcArpFahOperday Doc { get; set; }
    }
}
