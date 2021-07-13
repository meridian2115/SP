﻿using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class AttachDict
    {
        public decimal Attachid { get; set; }
        public decimal Dictid { get; set; }
        public decimal? ChangeVersion { get; set; }
    }
}