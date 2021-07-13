using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class VPqOutLow
    {
        public decimal? Id { get; set; }
        public string Url { get; set; }
        public DateTime? Createdate { get; set; }
        public DateTime? ChangeStatusDate { get; set; }
        public decimal? Seqnum { get; set; }
        public decimal? Sequencesize { get; set; }
        public string Guid { get; set; }
        public string Seqguid { get; set; }
        public decimal? FileSize { get; set; }
        public decimal? Priority { get; set; }
        public string Contentclassname { get; set; }
        public string Status { get; set; }
        public byte[] Blobcontent { get; set; }
        public string Errorcode { get; set; }
        public string Errormessage { get; set; }
        public string ToComplexId { get; set; }
        public decimal? OwnerDocsCount { get; set; }
    }
}
