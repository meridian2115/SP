﻿using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class DwCompReshTitle
    {
        public string NumResh { get; set; }
        public DateTime? Dateratification { get; set; }
        public decimal? FinYear { get; set; }
        public decimal? IsTotal { get; set; }
        public decimal? IsMigration { get; set; }
        public decimal? Accesslevel { get; set; }
        public decimal? IdMapingFormList { get; set; }
        public Guid? DocUuid { get; set; }
    }
}
