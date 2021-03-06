using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class FsAgrList
    {
        public decimal? Docid { get; set; }
        public decimal? Tablerownum { get; set; }
        public decimal Fieldsetid { get; set; }
        public string RtBudgetCode { get; set; }
        public string RtBudgetName { get; set; }
        public string RtFullname { get; set; }
        public string OrgGuid { get; set; }
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
        public string RtTypels { get; set; }
        public string PProgramm { get; set; }
        public string Login { get; set; }
        public string RtOrfkCode { get; set; }
        public string RtAccountnum { get; set; }
        public string RtOrfkName { get; set; }
        public string RtCoderegis { get; set; }
        public DateTime? Dataform { get; set; }
        public string XmlFormat { get; set; }
        public string AoPosition { get; set; }
        public string AoFullname { get; set; }
        public string AoTelephone { get; set; }
        public string AoExecuser { get; set; }
        public string RtTypels2 { get; set; }

        public virtual DcArpFahAccpac Doc { get; set; }
    }
}
