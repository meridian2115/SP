using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class Dictfieldchangelog
    {
        public decimal Id { get; set; }
        public decimal Version { get; set; }
        public decimal Dictchangelogid { get; set; }
        public string Fieldtype { get; set; }
        public string Fieldname { get; set; }
        public string Newvalue { get; set; }
    }
}
