using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class HfsInfoTable071List
    {
        public decimal Fieldsetid { get; set; }
        public decimal? Tablerownum { get; set; }
        public decimal? Id { get; set; }
        public string C3R071 { get; set; }
        public decimal? C4R071 { get; set; }
        public string C5R071 { get; set; }
        public string C3aR0711 { get; set; }
        public string C3bR0711 { get; set; }
        public string C3cR0711 { get; set; }
        public string C3dR0711 { get; set; }
        public string C3eR0711 { get; set; }

        public virtual HReport0503177 IdNavigation { get; set; }
    }
}
