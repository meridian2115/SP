﻿using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class FsListsList
    {
        public decimal? Docid { get; set; }
        public decimal? Tablerownum { get; set; }
        public decimal Fieldsetid { get; set; }
        public string Grouporder { get; set; }
        public string Fio { get; set; }
        public string Login { get; set; }
        public string Soglas { get; set; }
        public string Position { get; set; }
        public string Department { get; set; }
        public decimal? Ord { get; set; }

        public virtual DcArpSoglas Doc { get; set; }
    }
}