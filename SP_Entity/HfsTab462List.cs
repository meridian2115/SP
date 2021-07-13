using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class HfsTab462List
    {
        public decimal Fieldsetid { get; set; }
        public decimal? Tablerownum { get; set; }
        public decimal? Id { get; set; }
        public string C3Kbk { get; set; }
        public string C3aKbk { get; set; }
        public string C3bKbk { get; set; }
        public string C3cKbk { get; set; }
        public string C3dKbk { get; set; }

        public virtual HArpReport0521462 IdNavigation { get; set; }
    }
}
