using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class HfsBe1T2021fkList
    {
        public decimal Fieldsetid { get; set; }
        public decimal? Tablerownum { get; set; }
        public decimal? Id { get; set; }
        public string C2R2001 { get; set; }
        public string C2aR2001 { get; set; }
        public string C2bR2001 { get; set; }
        public string C2cR2001 { get; set; }
        public string C2dR2001 { get; set; }

        public virtual HArpReport0507021Fk IdNavigation { get; set; }
    }
}
