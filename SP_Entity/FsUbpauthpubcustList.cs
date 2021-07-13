﻿using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class FsUbpauthpubcustList
    {
        public decimal Fieldsetid { get; set; }
        public decimal? Tablerownum { get; set; }
        public decimal? Docid { get; set; }
        public DateTime? Authstartdate { get; set; }
        public DateTime? Authenddate { get; set; }
        public string Authpubclientcode { get; set; }

        public virtual DcRefUbpandnubp Doc { get; set; }
    }
}
