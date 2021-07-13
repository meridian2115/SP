using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class Userrequisites
    {
        public decimal Userrequisitesid { get; set; }
        public decimal? Version { get; set; }
        public string Fio { get; set; }
        public string Inn { get; set; }
        public string Notes { get; set; }
        public string Iddocdata { get; set; }
        public string Iddoctype { get; set; }
        public decimal? Physicaladdressid { get; set; }
        public decimal? Registrationaddressid { get; set; }
        public string Snils { get; set; }

        public virtual Postaladdress Physicaladdress { get; set; }
        public virtual Postaladdress Registrationaddress { get; set; }
    }
}
