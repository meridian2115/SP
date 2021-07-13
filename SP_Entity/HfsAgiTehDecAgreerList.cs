using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class HfsAgiTehDecAgreerList
    {
        public decimal Fieldsetid { get; set; }
        public decimal? Tablerownum { get; set; }
        public decimal? Id { get; set; }
        public string AgreerNote { get; set; }
        public DateTime? AgreerStartdate { get; set; }
        public DateTime? AgreerDate { get; set; }

        public virtual HExpInfbo IdNavigation { get; set; }
    }
}
