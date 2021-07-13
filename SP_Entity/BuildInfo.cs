using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class BuildInfo
    {
        public decimal BuildId { get; set; }
        public string BuildNum { get; set; }
        public DateTime? BuildData { get; set; }
        public string BuildTarget { get; set; }
        public decimal? BuildType { get; set; }
        public string BuildRef { get; set; }
    }
}
