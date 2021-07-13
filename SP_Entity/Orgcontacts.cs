using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class Orgcontacts
    {
        public decimal Orgcontactsid { get; set; }
        public decimal? Version { get; set; }
        public string Managername { get; set; }
        public string Managerphones { get; set; }
        public string Accountantname { get; set; }
        public string Accountantphones { get; set; }
        public string Faxnumber { get; set; }
        public string Email { get; set; }
    }
}
