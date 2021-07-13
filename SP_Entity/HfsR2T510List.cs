using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class HfsR2T510List
    {
        public decimal Fieldsetid { get; set; }
        public decimal? Tablerownum { get; set; }
        public decimal? Id { get; set; }
        public string C1R5101 { get; set; }
        public string C2R5101 { get; set; }
        public string C3R5101 { get; set; }
        public string C3aR5101 { get; set; }
        public string C3bR5101 { get; set; }
        public string C3cR5101 { get; set; }
        public string C3dR5101 { get; set; }
        public string C3eR5101 { get; set; }
        public decimal? C4R5101 { get; set; }
        public decimal? C5R5101 { get; set; }
        public decimal? C6R5101 { get; set; }
        public decimal? C7R5101 { get; set; }
        public decimal? C8R5101 { get; set; }
        public decimal? C9R5101 { get; set; }
        public decimal? C10R5101 { get; set; }
        public decimal? C11R5101 { get; set; }

        public virtual HReport0503738 IdNavigation { get; set; }
    }
}
