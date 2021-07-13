using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class HfsTab0503725List
    {
        public decimal Fieldsetid { get; set; }
        public decimal? Tablerownum { get; set; }
        public decimal? Id { get; set; }
        public string C1R11 { get; set; }
        public string C2R11 { get; set; }
        public string C3aR11 { get; set; }
        public string C3cR11 { get; set; }
        public string C3dR11 { get; set; }
        public string C3eR11 { get; set; }
        public decimal? C4R11 { get; set; }
        public decimal? C5R11 { get; set; }
        public string C6aR11 { get; set; }
        public string C6bR11 { get; set; }
        public string PlanAcc { get; set; }
        public string KvfoCode { get; set; }
        public string C6b1R11 { get; set; }
        public string C6b2R11 { get; set; }

        public virtual HArpreport0503725 IdNavigation { get; set; }
    }
}
