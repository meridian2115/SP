using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class ApConditionFile
    {
        public decimal Id { get; set; }
        public string Path { get; set; }
        public string Mask { get; set; }
    }
}
