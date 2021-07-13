using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class FsBrRevenue124List
    {
        public decimal? Docid { get; set; }
        public decimal? Tablerownum { get; set; }
        public decimal Fieldsetid { get; set; }
        public string LineCodeRvn { get; set; }
        public decimal? G4S0101 { get; set; }
        public decimal? G5S0101 { get; set; }
        public string KbkRCodeKbk { get; set; }
        public string KbkRNameKbk { get; set; }
        public string G3aS0101 { get; set; }
        public string G3bS0101 { get; set; }
        public string G3aN0101 { get; set; }
        public string G3bN0101 { get; set; }
        public string K3aS0101 { get; set; }
        public string K3bS0101 { get; set; }
        public string K3cS0101 { get; set; }
        public string K3dS0101 { get; set; }
        public string K3eS0101 { get; set; }

        public virtual DcReport0503124 Doc { get; set; }
    }
}
