using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class DoccontentRepServiceRequest
    {
        public decimal? Version { get; set; }
        public decimal Docid { get; set; }
        public decimal? Senderid { get; set; }
        public decimal? Receiverid { get; set; }
        public decimal? Addinfoid { get; set; }
        public string Requesttypecode { get; set; }
        public string Objectcode { get; set; }
        public string Errorid { get; set; }
        public string Errorinfo { get; set; }
        public string Errordata { get; set; }
        public DateTime? Errordate { get; set; }
        public string DocId1 { get; set; }
        public string Transportstate { get; set; }
        public string Transportstatecode { get; set; }
    }
}
