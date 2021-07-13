using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class Mw154
    {
        public int? Year { get; set; }
        public short? PeriodType { get; set; }
        public string GrbsCode { get; set; }
        public string Kvfo { get; set; }
        public short? Accesslevel { get; set; }
    }
}
