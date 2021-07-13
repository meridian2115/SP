using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class FsPofrbalanceinfoList
    {
        public decimal? Docid { get; set; }
        public decimal? Tablerownum { get; set; }
        public decimal Fieldsetid { get; set; }
        public string Numbrow { get; set; }
        public decimal? Apprvamount { get; set; }
        public decimal? Distramount { get; set; }
        public decimal? Resultamount { get; set; }
        public string Kbk { get; set; }

        public virtual DcMscExpendableschedule Doc { get; set; }
    }
}
