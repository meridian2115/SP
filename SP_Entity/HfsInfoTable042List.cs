using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class HfsInfoTable042List
    {
        public decimal Fieldsetid { get; set; }
        public decimal? Tablerownum { get; set; }
        public decimal? Id { get; set; }
        public string C3R042 { get; set; }
        public decimal? C4R042 { get; set; }
        public string C5R042 { get; set; }
        public string C3aR0421 { get; set; }
        public string C3bR0421 { get; set; }
        public string C3cR0421 { get; set; }
        public string C3dR0421 { get; set; }
        public string C3eR0421 { get; set; }

        public virtual HReport0503177 IdNavigation { get; set; }
    }
}
