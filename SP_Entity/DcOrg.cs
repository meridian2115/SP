using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class DcOrg
    {
        public decimal Docid { get; set; }
        public decimal? Version { get; set; }
        public string Name { get; set; }
        public string Systemname { get; set; }
        public DateTime? Id { get; set; }
        public string Orgogrn { get; set; }
        public string Orginn { get; set; }
        public string Orgkpp { get; set; }
        public string Orgkofk { get; set; }
    }
}
