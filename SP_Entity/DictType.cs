using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class DictType
    {
        public decimal Id { get; set; }
        public string Name { get; set; }
        public string Systemname { get; set; }
        public decimal Isdocumentary { get; set; }
        public decimal Islogenabled { get; set; }
    }
}
