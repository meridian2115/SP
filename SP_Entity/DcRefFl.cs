using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class DcRefFl
    {
        public decimal Docid { get; set; }
        public decimal? Version { get; set; }
        public string Cd { get; set; }
        public string Egrp { get; set; }
        public string Nm { get; set; }
        public DateTime? Db { get; set; }
        public string Gen { get; set; }
        public string Mr { get; set; }
        public string Inn { get; set; }
        public string Unit { get; set; }
        public string Adress { get; set; }
        public DateTime? DataStartactive { get; set; }
        public DateTime? DataEndactive { get; set; }
        public string Note { get; set; }
    }
}
