using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class AttachUserWork
    {
        public decimal Attachid { get; set; }
        public string Username { get; set; }
        public DateTime Downloadtime { get; set; }
    }
}
