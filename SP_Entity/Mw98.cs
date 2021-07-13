﻿using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class Mw98
    {
        public int? Year { get; set; }
        public DateTime? ReportDate { get; set; }
        public string GrbsCode { get; set; }
        public string KbkType { get; set; }
        public short? Accesslevel { get; set; }
    }
}
