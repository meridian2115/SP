using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class Doclink
    {
        public decimal Id { get; set; }
        public decimal? Version { get; set; }
        public decimal? LinkTypeId { get; set; }
        public string SourceGuid { get; set; }
        public bool? SourceTypeDict { get; set; }
        public string DestinationGuid { get; set; }
        public bool? DestinationTypeDict { get; set; }
        public DateTime? CreationDate { get; set; }
        public bool? Visible { get; set; }
        public bool? ReadOnly { get; set; }
        public string BpId { get; set; }
        public string BpName { get; set; }
        public string AuthorName { get; set; }
        public string AuthorUserName { get; set; }
    }
}
