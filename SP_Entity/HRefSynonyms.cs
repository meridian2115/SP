using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class HRefSynonyms
    {
        public decimal Id { get; set; }
        public string DocTp { get; set; }
        public string DocFld { get; set; }
        public string SynonymTp { get; set; }
        public string SynonymCd { get; set; }
        public string SynonymCdGuid { get; set; }
        public string Note { get; set; }
    }
}
