using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class DcConformityArFo
    {
        public decimal Docid { get; set; }
        public decimal? Version { get; set; }
        public string RecordNum { get; set; }
        public string Codereportform { get; set; }
        public string ArCode { get; set; }
        public string ArName { get; set; }
        public string Kvfo { get; set; }
        public string NmKvfo { get; set; }
        public DateTime? DataStartactive { get; set; }
        public DateTime? DataEndactive { get; set; }
        public string Note { get; set; }
    }
}
