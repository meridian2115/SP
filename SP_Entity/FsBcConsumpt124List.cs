using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class FsBcConsumpt124List
    {
        public decimal? Docid { get; set; }
        public decimal? Tablerownum { get; set; }
        public decimal Fieldsetid { get; set; }
        public string LineCodeCnsmptn { get; set; }
        public decimal? G4S2001 { get; set; }
        public decimal? G5S2001 { get; set; }
        public decimal? G6S2001 { get; set; }
        public decimal? G7S2001 { get; set; }
        public string KbkCCodeKbk { get; set; }
        public string KbkCNameKbk { get; set; }
        public decimal? G8S2001 { get; set; }
        public string G3aS2001 { get; set; }
        public string G3bS2001 { get; set; }
        public string G3cS2001 { get; set; }
        public string G3dS2001 { get; set; }
        public string G3aN2001 { get; set; }
        public string G3bN2001 { get; set; }
        public string G3cN2001 { get; set; }
        public string G3dN2001 { get; set; }

        public virtual DcReport0503124 Doc { get; set; }
    }
}
