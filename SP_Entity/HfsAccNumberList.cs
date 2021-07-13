using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class HfsAccNumberList
    {
        public decimal Fieldsetid { get; set; }
        public decimal? Tablerownum { get; set; }
        public decimal? Id { get; set; }
        public string C2R21 { get; set; }
        public string C3R21 { get; set; }
        public decimal? C4R21 { get; set; }
        public decimal? C5R21 { get; set; }
        public string C3aR21 { get; set; }
        public string C3cR21 { get; set; }
        public string C3dR21 { get; set; }
        public string C3eR21 { get; set; }
        public string PlanAccR2 { get; set; }

        public virtual HArpreport0503725 IdNavigation { get; set; }
    }
}
