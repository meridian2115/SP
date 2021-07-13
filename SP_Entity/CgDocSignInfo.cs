using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class CgDocSignInfo
    {
        public decimal Id { get; set; }
        public decimal? SignSchemeId { get; set; }
        public string SchemeName { get; set; }
        public bool? IsNewAlgorithm { get; set; }
        public decimal? Docid { get; set; }
        public string DocStateSystemName { get; set; }
    }
}
