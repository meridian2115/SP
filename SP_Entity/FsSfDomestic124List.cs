using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class FsSfDomestic124List
    {
        public decimal? Docid { get; set; }
        public decimal? Tablerownum { get; set; }
        public decimal Fieldsetid { get; set; }
        public string LineCodeDmstcFnc { get; set; }
        public decimal? G4S5201 { get; set; }
        public decimal? G5S5201 { get; set; }
        public decimal? G6S5201 { get; set; }
        public string KbkDfCodeKbk { get; set; }
        public string KbkDfNameKbk { get; set; }
        public decimal? G7S5201 { get; set; }
        public string G3aS5201 { get; set; }
        public string G3bS5201 { get; set; }
        public string G3aN5201 { get; set; }
        public string G3bN5201 { get; set; }
        public string K3aS5201 { get; set; }
        public string K3bS5201 { get; set; }
        public string K3cS5201 { get; set; }
        public string K3dS5201 { get; set; }
        public string K3eS5201 { get; set; }

        public virtual DcReport0503124 Doc { get; set; }
    }
}
