using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class HfsOfyR911List
    {
        public decimal Fieldsetid { get; set; }
        public decimal? Tablerownum { get; set; }
        public decimal? Id { get; set; }
        public string C3a { get; set; }
        public string C3b { get; set; }
        public string C3c { get; set; }
        public string C3e { get; set; }

        public virtual HArpReport0503129 IdNavigation { get; set; }
    }
}
