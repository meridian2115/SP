using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class HOkpo
    {
        public decimal Id { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public string Okogu { get; set; }
        public string Okato { get; set; }
        public string Okved { get; set; }
        public string Okfs { get; set; }
        public string Okopf { get; set; }
        public string Note { get; set; }
    }
}
