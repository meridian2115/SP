using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class FsT020151List
    {
        public decimal? Docid { get; set; }
        public decimal? Tablerownum { get; set; }
        public decimal Fieldsetid { get; set; }
        public string Name { get; set; }
        public string StrKod { get; set; }
        public string KbkRash { get; set; }
        public decimal? BRash { get; set; }
        public decimal? VremRash { get; set; }
        public decimal? ItogoRash { get; set; }
        public string Silent { get; set; }
        public string Kvd { get; set; }
        public string Codeschet { get; set; }
        public string Kosgu { get; set; }
        public string Kbk { get; set; }
        public string TypeKbk { get; set; }

        public virtual DcReport0503151 Doc { get; set; }
    }
}
