using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class QueuePacketIn
    {
        public decimal Id { get; set; }
        public string Filename { get; set; }
        public DateTime? Receivedate { get; set; }
        public string Seqguid { get; set; }
        public decimal? FileSize { get; set; }
        public byte[] Blobcontent { get; set; }
        public string Errormessage { get; set; }
        public string Status { get; set; }
        public string Complextype { get; set; }
        public bool Exported { get; set; }
        public string Errorcode { get; set; }
        public DateTime ChangeStatusDate { get; set; }
        public decimal Priority { get; set; }
        public decimal Processcount { get; set; }
        public decimal? OwnerDocsCount { get; set; }
        public string ObtainedThrough { get; set; }
    }
}
