using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class HArpReport0503117Fk
    {
        public HArpReport0503117Fk()
        {
            HfsR30503117Fk710aList = new HashSet<HfsR30503117Fk710aList>();
            HfsR30503117Fk720aList = new HashSet<HfsR30503117Fk720aList>();
        }

        public decimal Id { get; set; }
        public decimal? A700C4Sum { get; set; }
        public decimal? A700C5Sum { get; set; }
        public decimal? A700C6Sum { get; set; }
        public decimal? A700C7Sum { get; set; }
        public decimal? A700C8Sum { get; set; }
        public decimal? A700C9Sum { get; set; }
        public decimal? B700C4Sum { get; set; }
        public decimal? B700C5Sum { get; set; }
        public decimal? B700C6Sum { get; set; }
        public decimal? B700C7Sum { get; set; }
        public decimal? B700C8Sum { get; set; }
        public decimal? B700C9Sum { get; set; }
        public decimal? A710C4Sum { get; set; }
        public decimal? A710C5Sum { get; set; }
        public decimal? A710C6Sum { get; set; }
        public decimal? A710C7Sum { get; set; }
        public decimal? A710C8Sum { get; set; }
        public decimal? A710C9Sum { get; set; }
        public decimal? A720C4Sum { get; set; }
        public decimal? A720C5Sum { get; set; }
        public decimal? A720C6Sum { get; set; }
        public decimal? A720C7Sum { get; set; }
        public decimal? A720C8Sum { get; set; }
        public decimal? A720C9Sum { get; set; }

        public virtual ICollection<HfsR30503117Fk710aList> HfsR30503117Fk710aList { get; set; }
        public virtual ICollection<HfsR30503117Fk720aList> HfsR30503117Fk720aList { get; set; }
    }
}
