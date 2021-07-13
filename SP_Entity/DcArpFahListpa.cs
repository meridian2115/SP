using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class DcArpFahListpa
    {
        public decimal Docid { get; set; }
        public decimal? Version { get; set; }
        public string Npp { get; set; }
        public string Name { get; set; }
        public string CdSegmpa { get; set; }
        public string CdSegmbu { get; set; }
        public string CdAnpa { get; set; }
        public string CdAnbu { get; set; }
        public DateTime? DataStartactive { get; set; }
        public DateTime? DataEndactive { get; set; }
        public string Note { get; set; }
    }
}
