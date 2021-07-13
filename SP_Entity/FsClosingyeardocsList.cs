using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class FsClosingyeardocsList
    {
        public decimal? Docid { get; set; }
        public decimal? Tablerownum { get; set; }
        public decimal Fieldsetid { get; set; }
        public string Npp { get; set; }
        public string Type { get; set; }
        public string Name { get; set; }
        public string NumberDoc { get; set; }
        public DateTime? DateDoc { get; set; }
        public decimal? Sum { get; set; }

        public virtual DcArpFahClosingYear Doc { get; set; }
    }
}
