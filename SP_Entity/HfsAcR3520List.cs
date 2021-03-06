using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class HfsAcR3520List
    {
        public decimal Fieldsetid { get; set; }
        public decimal? Tablerownum { get; set; }
        public decimal? Id { get; set; }
        public string C1R5201 { get; set; }
        public string C2R5201 { get; set; }
        public string C3R5201 { get; set; }
        public string C3nR5201 { get; set; }
        public string C4R5201 { get; set; }
        public string C4nR5201 { get; set; }
        public string C5R5201 { get; set; }
        public string C5aR5201 { get; set; }
        public decimal? C6R5201 { get; set; }
        public decimal? C7R5201 { get; set; }
        public decimal? C8R5201 { get; set; }
        public decimal? C9R5201 { get; set; }
        public DateTime? RepDate520 { get; set; }
        public string PaCode { get; set; }

        public virtual HArpReport0531342 IdNavigation { get; set; }
    }
}
