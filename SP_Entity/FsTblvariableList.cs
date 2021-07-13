﻿using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class FsTblvariableList
    {
        public decimal? Docid { get; set; }
        public decimal? Tablerownum { get; set; }
        public decimal Fieldsetid { get; set; }
        public decimal? Line { get; set; }
        public string Name { get; set; }
        public string Expression { get; set; }
        public string Fielddoc { get; set; }
        public string Field { get; set; }

        public virtual DcPppCrSet Doc { get; set; }
    }
}
