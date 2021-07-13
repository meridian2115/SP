using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class SystemConstType
    {
        public decimal Typeid { get; set; }
        public string Name { get; set; }
        public string Systemname { get; set; }
        public string Description { get; set; }
        public string Acceptedvalues { get; set; }
        public decimal? Minvalue { get; set; }
        public decimal? Maxvalue { get; set; }
        public string Defaultvalue { get; set; }
        public bool? Overridable { get; set; }
    }
}
