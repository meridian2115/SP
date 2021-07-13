using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class HfsMTransList
    {
        public decimal Fieldsetid { get; set; }
        public decimal? Tablerownum { get; set; }
        public decimal? Id { get; set; }
        public string C2R31 { get; set; }
        public string C3R31 { get; set; }
        public decimal? C4R31 { get; set; }
        public decimal? C5R31 { get; set; }
        public string C6R31 { get; set; }
        public string C3aR31 { get; set; }
        public string C3cR31 { get; set; }
        public string C3dR31 { get; set; }
        public string C3eR31 { get; set; }
        public string PlanAccR3 { get; set; }

        public virtual HArpreport0503725 IdNavigation { get; set; }
    }
}
