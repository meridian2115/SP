using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class HRefJrnls
    {
        public decimal Id { get; set; }
        public string Nb { get; set; }
        public string Nm { get; set; }
        public string Prty { get; set; }
        public string FeatrNmGuid { get; set; }
        public string GrpFeatrNmGuid { get; set; }
        public string Note { get; set; }
    }
}
