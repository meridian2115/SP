using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class FsSfDecrease124List
    {
        public decimal? Docid { get; set; }
        public decimal? Tablerownum { get; set; }
        public decimal Fieldsetid { get; set; }
        public string LineCodeDecrease { get; set; }
        public decimal? G4S7201 { get; set; }
        public decimal? G5S7201 { get; set; }
        public string KbkDeCodeKbk { get; set; }
        public string KbkDeNameKbk { get; set; }
        public decimal? G6S7201 { get; set; }
        public decimal? G7S7201 { get; set; }
        public string G3aS7201 { get; set; }
        public string G3bS7201 { get; set; }
        public string G3aN7201 { get; set; }
        public string G3bN7201 { get; set; }
        public string K3aS7201 { get; set; }
        public string K3bS7201 { get; set; }
        public string K3cS7201 { get; set; }
        public string K3dS7201 { get; set; }
        public string K3eS7201 { get; set; }

        public virtual DcReport0503124 Doc { get; set; }
    }
}
