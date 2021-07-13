using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class Orgdata
    {
        public decimal Orgdataid { get; set; }
        public decimal? Version { get; set; }
        public string Financialname { get; set; }
        public string Fullname { get; set; }
        public string Internationalname { get; set; }
        public string Statecode { get; set; }
        public string Inn { get; set; }
        public string Kpp { get; set; }
        public string Okpo { get; set; }
        public string Bic { get; set; }
        public string Notes { get; set; }
        public decimal? Legaladdressid { get; set; }
        public decimal? Internationaladdressid { get; set; }
        public decimal? Orgcontactsid { get; set; }
        public decimal? Orgtypeid { get; set; }
        public string Globaldicid { get; set; }

        public virtual Postaladdress Internationaladdress { get; set; }
        public virtual Postaladdress Legaladdress { get; set; }
    }
}
