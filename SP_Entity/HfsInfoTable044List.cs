using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class HfsInfoTable044List
    {
        public decimal Fieldsetid { get; set; }
        public decimal? Tablerownum { get; set; }
        public decimal? Id { get; set; }
        public string C3R044 { get; set; }
        public decimal? C4R044 { get; set; }
        public string C5R044 { get; set; }
        public string C3aR0441 { get; set; }
        public string C3bR0441 { get; set; }
        public string C3cR0441 { get; set; }
        public string C3dR0441 { get; set; }
        public string C3eR0441 { get; set; }

        public virtual HReport0503177 IdNavigation { get; set; }
    }
}
