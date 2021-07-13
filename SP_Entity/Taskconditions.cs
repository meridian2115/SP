﻿using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class Taskconditions
    {
        public decimal Scheduleid { get; set; }
        public decimal? Taskid { get; set; }
        public string Name { get; set; }
        public string Expression { get; set; }
    }
}
