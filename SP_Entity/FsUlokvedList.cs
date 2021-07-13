﻿using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class FsUlokvedList
    {
        public decimal? Docid { get; set; }
        public decimal? Tablerownum { get; set; }
        public decimal Fieldsetid { get; set; }
        public DateTime? Dtstart { get; set; }
        public string Grn { get; set; }
        public string Main { get; set; }
        public string Kodokved { get; set; }

        public virtual DcRefEgrul Doc { get; set; }
    }
}
