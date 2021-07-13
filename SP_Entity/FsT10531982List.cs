using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class FsT10531982List
    {
        public decimal? Docid { get; set; }
        public decimal? Tablerownum { get; set; }
        public decimal Fieldsetid { get; set; }
        public string Cod1 { get; set; }
        public string Kvfo1 { get; set; }
        public string Schet1 { get; set; }
        public string Kosgy1 { get; set; }
        public decimal? T1Deb { get; set; }
        public decimal? T1Kred { get; set; }
        public string TypeKbk { get; set; }
        public string Num { get; set; }

        public virtual DcArpReport0531982 Doc { get; set; }
    }
}
