﻿using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class FsBa19T2000503830dList
    {
        public decimal? Docid { get; set; }
        public decimal? Tablerownum { get; set; }
        public decimal Fieldsetid { get; set; }
        public string C2R2001 { get; set; }
        public string C3R2001 { get; set; }
        public decimal? C4R2001 { get; set; }
        public decimal? C5R2001 { get; set; }
        public decimal? C6R2001 { get; set; }
        public decimal? C7R2001 { get; set; }
        public decimal? C8R2001 { get; set; }
        public decimal? C9R2001 { get; set; }
        public decimal? C10R2001 { get; set; }
        public decimal? C11R2001 { get; set; }
        public string Tabcounter200 { get; set; }

        public virtual DcArpReport0503830D Doc { get; set; }
    }
}
