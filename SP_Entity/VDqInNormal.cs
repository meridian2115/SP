using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class VDqInNormal
    {
        public string Guid { get; set; }
        public string Contentobjectguid { get; set; }
        public decimal? Priority { get; set; }
        public decimal? ResendCount { get; set; }
        public byte[] QueueItem { get; set; }
        public string Direction { get; set; }
        public string Contentclassname { get; set; }
        public string Errorcode { get; set; }
        public string ErrorMessage { get; set; }
        public string CreateOrgSysName { get; set; }
        public string ItemStatus { get; set; }
        public DateTime? CreationDate { get; set; }
        public DateTime? ChangeStatusDate { get; set; }
        public string TargetComplexType { get; set; }
        public bool? IsSystemTransit { get; set; }
        public string DoctypeName { get; set; }
        public string DocLogParentdocGuid { get; set; }
        public decimal? DocLogVersion { get; set; }
        public decimal? BlobSize { get; set; }
    }
}
