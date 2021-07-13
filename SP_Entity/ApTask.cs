using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class ApTask
    {
        public decimal Id { get; set; }
        public decimal Version { get; set; }
        public string Name { get; set; }
        public bool? Enabled { get; set; }
        public string Priority { get; set; }
        public bool? InitSystem { get; set; }
        public string Guid { get; set; }
        public string Execoperation { get; set; }
    }
}
