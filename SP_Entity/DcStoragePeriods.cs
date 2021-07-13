using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class DcStoragePeriods
    {
        public decimal Docid { get; set; }
        public decimal? Version { get; set; }
        public string Segment1 { get; set; }
        public string Description { get; set; }
        public DateTime? StoragePeriods { get; set; }
        public bool? SignOfActivity { get; set; }
    }
}
