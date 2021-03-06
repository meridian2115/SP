using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class FsItogoinnList
    {
        public decimal? Docid { get; set; }
        public decimal? Tablerownum { get; set; }
        public decimal Fieldsetid { get; set; }
        public string Namecont { get; set; }
        public string Innitogo { get; set; }
        public decimal? AmountInn { get; set; }
        public decimal? TotalInn { get; set; }
        public decimal? OverdueInn { get; set; }
        public decimal? TotalEndpInn { get; set; }
        public decimal? ConfnfInn { get; set; }
        public decimal? ArrearsInn { get; set; }
        public decimal? RepayfbInn { get; set; }
        public decimal? ScheduledDebtEndpInn { get; set; }
        public string NumberBo { get; set; }
        public string CodeKofk { get; set; }

        public virtual DcReport0503193 Doc { get; set; }
    }
}
