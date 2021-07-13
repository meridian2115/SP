using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class DcKosgu
    {
        public decimal Docid { get; set; }
        public decimal? Version { get; set; }
        public string Segment1 { get; set; }
        public string Description { get; set; }
        public bool? CashOpr { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public string Bccnt { get; set; }
        public string KosguBccdbtName { get; set; }
        public string KosguBccdbtCode { get; set; }
    }
}
