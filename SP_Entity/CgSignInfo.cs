using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class CgSignInfo
    {
        public decimal Id { get; set; }
        public decimal? CipherAlgorithmId { get; set; }
        public decimal? HashAlgorithmId { get; set; }
        public decimal? CspInfoId { get; set; }
        public string CertFingerprint { get; set; }
        public string SubjectCname { get; set; }
        public string SubjectTitle { get; set; }
        public string SubjectOrg { get; set; }
        public bool? IsLocal { get; set; }
        public DateTime? CreationDate { get; set; }
        public bool? IsAdvanced { get; set; }
        public string AdvStatus { get; set; }
        public string AdvErrorCode { get; set; }
        public string AdvErrorMess { get; set; }
        public string LastCheckStatus { get; set; }
        public DateTime? LastCheckDate { get; set; }
        public decimal Version { get; set; }
        public string Guid { get; set; }
        public string LastInspectorSysname { get; set; }
        public string WhatSigned { get; set; }
        public string SubjectOrgSystemName { get; set; }
        public string CreationLogin { get; set; }
        public string SignFormat { get; set; }
        public string UserName { get; set; }
        public byte[] CmsSignedData { get; set; }
        public byte[] CertifyingHash { get; set; }
        public byte[] SignedData { get; set; }
        public bool? ExternalSign { get; set; }
        public string Transformation { get; set; }
        public string DocumentPath { get; set; }
    }
}
