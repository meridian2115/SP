using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class FsSfExternal124List
    {
        public decimal? Docid { get; set; }
        public decimal? Tablerownum { get; set; }
        public decimal Fieldsetid { get; set; }
        public string LineCodeExtrnlFnc { get; set; }
        public decimal? G4S6201 { get; set; }
        public decimal? G5S6201 { get; set; }
        public decimal? G6S6201 { get; set; }
        public string KbkEfCodeKbk { get; set; }
        public string KbkEfNameKbk { get; set; }
        public decimal? G7S6201 { get; set; }
        public string G3aS6201 { get; set; }
        public string G3bS6201 { get; set; }
        public string G3aN6201 { get; set; }
        public string G3bN6201 { get; set; }
        public string K3aS6201 { get; set; }
        public string K3bS6201 { get; set; }
        public string K3cS6201 { get; set; }
        public string K3dS6201 { get; set; }
        public string K3eS6201 { get; set; }

        public virtual DcReport0503124 Doc { get; set; }
    }
}
