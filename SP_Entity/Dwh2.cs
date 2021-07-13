using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class Dwh2
    {
        public Guid Uuid { get; set; }
        public decimal? HeaderId { get; set; }
        public DateTime? ReportDate { get; set; }
        public string ReportNum { get; set; }
        public int? Year { get; set; }
    }
}
