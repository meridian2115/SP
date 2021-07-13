using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class MapingTableList
    {
        public decimal? SourceId { get; set; }
        public string SourceCol { get; set; }
        public string TargetCol { get; set; }
        public string TargetTable { get; set; }
    }
}
