using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class HfsTabR1List
    {
        public decimal Fieldsetid { get; set; }
        public decimal? Tablerownum { get; set; }
        public decimal? Id { get; set; }
        public string C3R1 { get; set; }
        public string C4R1 { get; set; }
        public string C5R1 { get; set; }
        public string C6R1 { get; set; }

        public virtual HArpReportLstdcsns IdNavigation { get; set; }
    }
}
