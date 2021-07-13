using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class FsTlsList
    {
        public decimal? Docid { get; set; }
        public decimal? Tablerownum { get; set; }
        public decimal Fieldsetid { get; set; }
        public string RtTypels { get; set; }
        public string RtFormcode { get; set; }
        public string RtFormname { get; set; }
        public string AoCreateifempty { get; set; }
        public string AoShowlnzero { get; set; }
        public string AddRpDocs { get; set; }
        public string ReportType { get; set; }
        public string ReportTypeFlag { get; set; }
        public string FormatRtf { get; set; }
        public string FormatPdf { get; set; }
        public string FormatExl { get; set; }
        public string FormatTxt { get; set; }
        public string XmlFormat { get; set; }
        public string PProgramm { get; set; }

        public virtual DcArpFahAccpac Doc { get; set; }
    }
}
