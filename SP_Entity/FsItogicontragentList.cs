using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class FsItogicontragentList
    {
        public decimal? Docid { get; set; }
        public decimal? Tablerownum { get; set; }
        public decimal Fieldsetid { get; set; }
        public string Inncontragent { get; set; }
        public decimal? TotalBy { get; set; }
        public decimal? OverdueBy { get; set; }
        public decimal? TotalEndp { get; set; }
        public decimal? OverdueEndp { get; set; }
        public decimal? ScheduledDebtEndp { get; set; }
        public decimal? Amounti { get; set; }
        public string Namecontractor { get; set; }
        public string NumberOfEntries { get; set; }
        public string CodeKofk { get; set; }
        public string NumberBo { get; set; }

        public virtual DcReport0503192 Doc { get; set; }
    }
}
