using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class HReport0503184
    {
        public HReport0503184()
        {
            HfsBrRevenue184List = new HashSet<HfsBrRevenue184List>();
            HfsSfDomestic184List = new HashSet<HfsSfDomestic184List>();
        }

        public decimal Id { get; set; }
        public string BrRvTotalC2R0101 { get; set; }
        public decimal? BrRvTotalC4R0101 { get; set; }
        public string SfDomTotalC2R5201 { get; set; }
        public decimal? SfDomTotalC4R5201 { get; set; }
        public string SfIncTotalC2R710 { get; set; }
        public decimal? SfIncTotalC4R710 { get; set; }

        public virtual ICollection<HfsBrRevenue184List> HfsBrRevenue184List { get; set; }
        public virtual ICollection<HfsSfDomestic184List> HfsSfDomestic184List { get; set; }
    }
}
