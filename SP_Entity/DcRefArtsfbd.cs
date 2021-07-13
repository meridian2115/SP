using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class DcRefArtsfbd
    {
        public decimal Docid { get; set; }
        public decimal? Version { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public string GrCodegroup { get; set; }
        public string GrNamegroup { get; set; }
        public string CsmoCodecsmo { get; set; }
        public string CsmoNamecsmo { get; set; }
        public string Note { get; set; }
        public DateTime? DataStartactive { get; set; }
        public DateTime? DataEndactive { get; set; }
    }
}
