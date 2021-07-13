using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class HRefPeracc
    {
        public decimal Id { get; set; }
        public string Accnum { get; set; }
        public string Acctype { get; set; }
        public string Legalname { get; set; }
        public string Legaladdress { get; set; }
        public string Indtxpridntnm { get; set; }
        public string Cdrsnrg { get; set; }
        public string Codefinauth { get; set; }
        public string Namefinauth { get; set; }
        public string Note { get; set; }
    }
}
