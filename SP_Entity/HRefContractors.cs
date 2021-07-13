using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class HRefContractors
    {
        public decimal Id { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public string Indtaxidnum { get; set; }
        public string Cdrsnrg { get; set; }
        public string Ncm { get; set; }
        public string Nceo { get; set; }
        public string Ncc { get; set; }
        public string Address { get; set; }
        public string Note { get; set; }
    }
}
