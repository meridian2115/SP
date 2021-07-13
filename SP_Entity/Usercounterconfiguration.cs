using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class Usercounterconfiguration
    {
        public decimal Id { get; set; }
        public decimal? Version { get; set; }
        public decimal Counterid { get; set; }
        public decimal? Orgid { get; set; }
        public string Mask { get; set; }
    }
}
