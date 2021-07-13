using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class Groupcounterconfiguration
    {
        public decimal Id { get; set; }
        public decimal Counterid { get; set; }
        public decimal? Version { get; set; }
        public decimal? GroupIndex { get; set; }
        public string Organization { get; set; }
        public string Year { get; set; }
        public string Quarter { get; set; }
        public string Month { get; set; }
        public string Week { get; set; }
        public string Day { get; set; }
        public bool? Fieldname1 { get; set; }
        public bool? Fieldname2 { get; set; }
        public bool? Fieldname3 { get; set; }
        public bool? Fieldname4 { get; set; }
        public bool? Fieldname5 { get; set; }
        public string Counter1 { get; set; }
        public string Counter2 { get; set; }
        public string Counter3 { get; set; }
        public string Counter4 { get; set; }
    }
}
