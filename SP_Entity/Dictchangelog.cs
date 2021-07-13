using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class Dictchangelog
    {
        public decimal Id { get; set; }
        public decimal Version { get; set; }
        public DateTime Logdate { get; set; }
        public decimal Dictid { get; set; }
        public string Complexname { get; set; }
        public string Username { get; set; }
    }
}
