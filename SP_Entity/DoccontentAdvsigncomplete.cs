using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class DoccontentAdvsigncomplete
    {
        public decimal? Version { get; set; }
        public decimal Docid { get; set; }
        public decimal? ObjectId { get; set; }
        public string ErrMessage { get; set; }
        public bool? Completed { get; set; }
        public string PrevDocGuid { get; set; }
        public string ObjectType { get; set; }
    }
}
