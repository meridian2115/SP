using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class HfsInfoUnexrec230List
    {
        public decimal Fieldsetid { get; set; }
        public decimal? Tablerownum { get; set; }
        public decimal? Id { get; set; }
        public string C3R1901 { get; set; }
        public decimal? C4R1901 { get; set; }
        public decimal? C5R1901 { get; set; }
        public string Tabcounter5 { get; set; }

        public virtual HReport0503230 IdNavigation { get; set; }
    }
}
