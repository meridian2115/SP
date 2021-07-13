using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class DoctypeidChange
    {
        public string Systemname { get; set; }
        public decimal? OldDoctypeid { get; set; }
        public decimal? NewDoctypeid { get; set; }
        public DateTime? ChangeTime { get; set; }
    }
}
