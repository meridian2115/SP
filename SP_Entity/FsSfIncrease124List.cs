using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class FsSfIncrease124List
    {
        public decimal? Docid { get; set; }
        public decimal? Tablerownum { get; set; }
        public decimal Fieldsetid { get; set; }
        public string LineCodeIncrease { get; set; }
        public decimal? G4S7101 { get; set; }
        public decimal? G5S7101 { get; set; }
        public string KbkInCodeKbk { get; set; }
        public string KbkInNameKbk { get; set; }
        public decimal? G6S7101 { get; set; }
        public decimal? G7S7101 { get; set; }
        public string G3aS7101 { get; set; }
        public string G3bS7101 { get; set; }
        public string G3aN7101 { get; set; }
        public string G3bN7101 { get; set; }
        public string K3aS7101 { get; set; }
        public string K3bS7101 { get; set; }
        public string K3cS7101 { get; set; }
        public string K3dS7101 { get; set; }
        public string K3eS7101 { get; set; }

        public virtual DcReport0503124 Doc { get; set; }
    }
}
