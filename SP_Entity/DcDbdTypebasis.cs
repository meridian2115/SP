using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class DcDbdTypebasis
    {
        public decimal Docid { get; set; }
        public decimal? Version { get; set; }
        public string Basiscode { get; set; }
        public string Basisname { get; set; }
        public DateTime? PeriodStartdate { get; set; }
        public DateTime? PeriodEnddate { get; set; }
        public string TofkName { get; set; }
        public string TofkCode { get; set; }
        public string SiTfGuid { get; set; }
        public string SiTfOrgsysname { get; set; }
        public string SiTfTransferstate { get; set; }
        public string SiTfTransfererror { get; set; }
        public string SiTfClientstate { get; set; }
        public string SiTfBodid { get; set; }
        public string SiTfAsfkstate { get; set; }
        public string Code { get; set; }
        public DateTime? Datechange { get; set; }
    }
}
