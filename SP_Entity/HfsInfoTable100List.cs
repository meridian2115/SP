using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class HfsInfoTable100List
    {
        public decimal Fieldsetid { get; set; }
        public decimal? Tablerownum { get; set; }
        public decimal? Id { get; set; }
        public string C3R100 { get; set; }
        public decimal? C4R100 { get; set; }
        public string C5R100 { get; set; }
        public string C3aR1001 { get; set; }
        public string C3bR1001 { get; set; }
        public string C3cR1001 { get; set; }
        public string C3dR1001 { get; set; }
        public string C3eR1001 { get; set; }

        public virtual HReport0503177 IdNavigation { get; set; }
    }
}
