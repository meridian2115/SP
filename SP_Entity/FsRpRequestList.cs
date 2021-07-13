using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class FsRpRequestList
    {
        public decimal Fieldsetid { get; set; }
        public decimal? Tablerownum { get; set; }
        public decimal? Docid { get; set; }
        public DateTime? RequestDate { get; set; }
        public DateTime? RequestDateEnd { get; set; }
        public string RequestGuid { get; set; }
        public string RequestFlag { get; set; }
        public string RequestText { get; set; }
        public string RequestSys { get; set; }
        public string RequestState { get; set; }
        public string RequestSysCode { get; set; }

        public virtual DcArpReportAccls Doc { get; set; }
    }
}
