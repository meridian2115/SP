using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class Securityprofile
    {
        public decimal Securityprofileid { get; set; }
        public decimal? Version { get; set; }
        public string Name { get; set; }
        public decimal? Maxauthattempts { get; set; }
        public bool? Allowchangepassword { get; set; }
        public decimal? Minpasswordlength { get; set; }
        public bool? Passwordrequired { get; set; }
        public bool? Requestpasswordchange { get; set; }
    }
}
