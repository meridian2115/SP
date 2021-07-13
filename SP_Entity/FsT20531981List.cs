using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class FsT20531981List
    {
        public decimal? Docid { get; set; }
        public decimal? Tablerownum { get; set; }
        public decimal Fieldsetid { get; set; }
        public string GS2DCsegment2 { get; set; }
        public string Cod2 { get; set; }
        public string Kvfo2 { get; set; }
        public string Schet2 { get; set; }
        public string Kosgy1 { get; set; }
        public decimal? T2Deb { get; set; }
        public decimal? T2Kred { get; set; }
        public string TypeKbk2 { get; set; }
        public string Num2 { get; set; }

        public virtual DcArpReport0531981 Doc { get; set; }
    }
}
