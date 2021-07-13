using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class Auditlog
    {
        public decimal Eventid { get; set; }
        public DateTime? Eventdate { get; set; }
        public decimal? Officeid { get; set; }
        public decimal? Userid { get; set; }
        public string Username { get; set; }
        public string Entitytype { get; set; }
        public string Eventtype { get; set; }
        public decimal? Entityid { get; set; }
        public string Info { get; set; }
    }
}
