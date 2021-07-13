using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class Versions
    {
        public string FuncVersion { get; set; }
        public string CoreVersion { get; set; }
        public DateTime? UpdateDate { get; set; }
        public string Sp { get; set; }
    }
}
