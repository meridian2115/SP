using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class Orgtype
    {
        public decimal Orgtypeid { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal? Bydefault { get; set; }
    }
}
