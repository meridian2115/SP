using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class Postaladdress
    {
        public Postaladdress()
        {
            OrgdataInternationaladdress = new HashSet<Orgdata>();
            OrgdataLegaladdress = new HashSet<Orgdata>();
            UserrequisitesPhysicaladdress = new HashSet<Userrequisites>();
            UserrequisitesRegistrationaddress = new HashSet<Userrequisites>();
        }

        public decimal Postaladdressid { get; set; }
        public decimal? Version { get; set; }
        public string Address { get; set; }
        public string Area { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public string Zip { get; set; }

        public virtual ICollection<Orgdata> OrgdataInternationaladdress { get; set; }
        public virtual ICollection<Orgdata> OrgdataLegaladdress { get; set; }
        public virtual ICollection<Userrequisites> UserrequisitesPhysicaladdress { get; set; }
        public virtual ICollection<Userrequisites> UserrequisitesRegistrationaddress { get; set; }
    }
}
