using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class FsT010151List
    {
        public decimal? Docid { get; set; }
        public decimal? Tablerownum { get; set; }
        public decimal Fieldsetid { get; set; }
        public string Name { get; set; }
        public string StrKod { get; set; }
        public string KbkDoh { get; set; }
        public string TypeKbk { get; set; }
        public decimal? BDoh { get; set; }
        public decimal? VremDoh { get; set; }
        public decimal? ItogoDoh { get; set; }
        public string Silent { get; set; }
        public string Kvd { get; set; }
        public string Codeschet { get; set; }
        public string Kosgu { get; set; }
        public string Kbk { get; set; }

        public virtual DcReport0503151 Doc { get; set; }
    }
}
