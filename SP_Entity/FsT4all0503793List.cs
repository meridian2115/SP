using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class FsT4all0503793List
    {
        public decimal? Docid { get; set; }
        public decimal? Tablerownum { get; set; }
        public decimal Fieldsetid { get; set; }
        public string NameChirtAll { get; set; }
        public string NumaccAll { get; set; }
        public string KppvAll { get; set; }
        public string KvfoAll { get; set; }
        public string AccbuAll { get; set; }
        public string KosguAll { get; set; }
        public decimal? TotalAll { get; set; }
        public decimal? OverdueAll { get; set; }
        public decimal? TotalEndpAll { get; set; }
        public decimal? ConfnfAll { get; set; }
        public decimal? ArrearsAll { get; set; }
        public decimal? RepayfbAll { get; set; }
        public decimal? ScheduledDebtEndpAll { get; set; }

        public virtual DcArpReport0503793 Doc { get; set; }
    }
}
