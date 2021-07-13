using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class HArpReport0531342
    {
        public HArpReport0531342()
        {
            HfsAaR1010List = new HashSet<HfsAaR1010List>();
            HfsAbR1200List = new HashSet<HfsAbR1200List>();
            HfsAcR3520List = new HashSet<HfsAcR3520List>();
            HfsAcR3825List = new HashSet<HfsAcR3825List>();
            HfsAcR3826List = new HashSet<HfsAcR3826List>();
        }

        public decimal Id { get; set; }
        public string System { get; set; }
        public string System1 { get; set; }
        public decimal? AaC6R010 { get; set; }
        public decimal? AaC7R010 { get; set; }
        public decimal? AaC8R010 { get; set; }
        public decimal? AaC9R010 { get; set; }
        public decimal? AbC6R200 { get; set; }
        public decimal? AbC7R200 { get; set; }
        public decimal? AbC8R200 { get; set; }
        public decimal? AbC9R200 { get; set; }
        public decimal? AcC6R520 { get; set; }
        public decimal? AcC7R520 { get; set; }
        public decimal? AcC8R520 { get; set; }
        public decimal? AcC9R520 { get; set; }
        public decimal? AcC6R800 { get; set; }
        public decimal? AcC7R800 { get; set; }
        public decimal? AcC8R800 { get; set; }
        public decimal? AcC9R800 { get; set; }
        public decimal? AcC6R825 { get; set; }
        public decimal? AcC7R825 { get; set; }
        public decimal? AcC8R825 { get; set; }
        public decimal? AcC9R825 { get; set; }
        public decimal? AcC6R826 { get; set; }
        public decimal? AcC7R826 { get; set; }
        public decimal? AcC8R826 { get; set; }
        public decimal? AcC9R826 { get; set; }
        public string Surrogat { get; set; }

        public virtual ICollection<HfsAaR1010List> HfsAaR1010List { get; set; }
        public virtual ICollection<HfsAbR1200List> HfsAbR1200List { get; set; }
        public virtual ICollection<HfsAcR3520List> HfsAcR3520List { get; set; }
        public virtual ICollection<HfsAcR3825List> HfsAcR3825List { get; set; }
        public virtual ICollection<HfsAcR3826List> HfsAcR3826List { get; set; }
    }
}
