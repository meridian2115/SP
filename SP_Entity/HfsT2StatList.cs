using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class HfsT2StatList
    {
        public decimal Fieldsetid { get; set; }
        public decimal? Tablerownum { get; set; }
        public decimal? Id { get; set; }
        public string Cdsubjreport { get; set; }
        public string Cdalt { get; set; }
        public string Nmsubjreport { get; set; }

        public virtual HArpStatpredotch IdNavigation { get; set; }
    }
}
