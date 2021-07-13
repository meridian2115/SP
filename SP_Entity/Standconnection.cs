using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class Standconnection
    {
        public string Host { get; set; }
        public decimal? Port { get; set; }
        public string Userdir { get; set; }
        public DateTime? Dateinit { get; set; }
        public string UniqueField { get; set; }
    }
}
