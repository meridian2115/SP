using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class DcArpFahDiffrep
    {
        public decimal Docid { get; set; }
        public decimal? Version { get; set; }
        public string PReportSet { get; set; }
        public string PReportSetn { get; set; }
        public string PTofkOpenCode { get; set; }
        public string PTofkOpenCode1 { get; set; }
        public string PTofkOpenCode2 { get; set; }
        public DateTime? PReportDate { get; set; }
        public string PAsfk { get; set; }
        public string PFormatRtf { get; set; }
        public string PFormatPdf { get; set; }
        public string PFormatExl { get; set; }
        public string StatusName { get; set; }
        public string PhaseName { get; set; }
        public string CompletionText { get; set; }
        public string NPpRep { get; set; }
        public string RepNm { get; set; }
        public string Reasonreject { get; set; }
        public DateTime? DatetimeRep { get; set; }
        public DateTime? PBeginGlDate { get; set; }
        public DateTime? PEndGlDate { get; set; }
        public string FioExecutor { get; set; }
        public string Tmp { get; set; }
        public string Format { get; set; }
        public string Inst { get; set; }
    }
}
