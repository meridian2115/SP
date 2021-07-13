using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class DcArpInfoPuio
    {
        public DcArpInfoPuio()
        {
            FsApInfopuioList = new HashSet<FsApInfopuioList>();
            FsInfoPuioTabList = new HashSet<FsInfoPuioTabList>();
        }

        public decimal Docid { get; set; }
        public decimal? Version { get; set; }
        public DateTime? ReportDate { get; set; }
        public string Tofk { get; set; }
        public string NameTofk { get; set; }
        public string CdBudget { get; set; }
        public string AccountTypes { get; set; }
        public string EmptyData { get; set; }
        public string Stat { get; set; }
        public string Phase { get; set; }
        public string TextCompletion { get; set; }
        public string PFormatRtf { get; set; }
        public string PFormatTxt { get; set; }
        public string PFormatPdf { get; set; }
        public string PFormatExl { get; set; }
        public string PXmlFormat { get; set; }
        public string Instcd { get; set; }
        public string Name { get; set; }
        public string Stateasfk { get; set; }
        public string Npp { get; set; }
        public string CancelComment { get; set; }
        public string PUfosGuid { get; set; }
        public string StructSub { get; set; }
        public string Okpo { get; set; }
        public string Inn { get; set; }
        public string Kpp { get; set; }
        public string PeriodAccType { get; set; }
        public string Guidreceipt { get; set; }
        public string Fksystem { get; set; }
        public string Fksegmentcode { get; set; }
        public string Sourcesystem { get; set; }
        public string Isdocument { get; set; }
        public string ApLoginGb { get; set; }
        public string ApLoginRfes { get; set; }
        public string ApLoginR { get; set; }
        public string ApFioGb { get; set; }
        public string ApFioRfes { get; set; }
        public string ApFioR { get; set; }
        public string ApDepartmentGb { get; set; }
        public string ApDepartmentRfes { get; set; }
        public string ApDepartmentR { get; set; }
        public string ApPostfieldR { get; set; }
        public string ApPostfieldRfes { get; set; }
        public string ApPostfieldGb { get; set; }
        public bool? ApScipsoglas { get; set; }
        public string ApSoglasGb { get; set; }
        public string ApSoglasRfes { get; set; }
        public string ApSoglasR { get; set; }
        public string ApNoteGb { get; set; }
        public string ApNoteRfes { get; set; }
        public string ApNoteR { get; set; }
        public string Numbls { get; set; }
        public string Docsystemname { get; set; }
        public string Doctype { get; set; }
        public string Errbuf { get; set; }
        public string ReturnStatus { get; set; }

        public virtual ICollection<FsApInfopuioList> FsApInfopuioList { get; set; }
        public virtual ICollection<FsInfoPuioTabList> FsInfoPuioTabList { get; set; }
    }
}
