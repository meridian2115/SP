using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class HfsR30503117Fk710aList
    {
        public decimal Fieldsetid { get; set; }
        public decimal? Tablerownum { get; set; }
        public decimal? Id { get; set; }
        public string C1Name { get; set; }
        public string C2Code { get; set; }
        public decimal? C4Sum { get; set; }
        public decimal? C5Sum { get; set; }
        public decimal? C6Sum { get; set; }
        public decimal? C7Sum { get; set; }
        public decimal? C8Sum { get; set; }
        public decimal? C9Sum { get; set; }

        public virtual HArpReport0503117Fk IdNavigation { get; set; }
    }
}
