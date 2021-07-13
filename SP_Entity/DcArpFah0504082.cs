using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class DcArpFah0504082
    {
        public DcArpFah0504082()
        {
            FsApApprovalList = new HashSet<FsApApprovalList>();
            FsTbl10504082List = new HashSet<FsTbl10504082List>();
        }

        public decimal Docid { get; set; }
        public decimal? Version { get; set; }
        public DateTime? PReportDate { get; set; }
        public DateTime? PBeginInvDate { get; set; }
        public DateTime? PEndInvDate { get; set; }
        public string PUfk { get; set; }
        public string PNmUfk { get; set; }
        public string PAccount { get; set; }
        public string PAcc1 { get; set; }
        public string PAcc2 { get; set; }
        public string PAcc3 { get; set; }
        public string PAcc4 { get; set; }
        public string PAcc5 { get; set; }
        public string POrderNmb { get; set; }
        public DateTime? POrderDate { get; set; }
        public string PLocation { get; set; }
        public string PEmptyData { get; set; }
        public string PFormatRtf { get; set; }
        public string PFormatTxt { get; set; }
        public string PFormatPdf { get; set; }
        public string PFormatExl { get; set; }
        public string PXmlFormat { get; set; }
        public string PStat { get; set; }
        public string PPhase { get; set; }
        public string PTextCompletion { get; set; }
        public string PUfosGuid { get; set; }
        public string ApLoginCm1 { get; set; }
        public string ApFioCm1 { get; set; }
        public string ApDepartmentCm1 { get; set; }
        public string ApPostfieldCm1 { get; set; }
        public string ApSoglasCm1 { get; set; }
        public string ApNoteCm1 { get; set; }
        public string ApLoginCm2 { get; set; }
        public string ApFioCm2 { get; set; }
        public string ApDepartmentCm2 { get; set; }
        public string ApPostfieldCm2 { get; set; }
        public string ApSoglasCm2 { get; set; }
        public string ApNoteCm2 { get; set; }
        public string ApLoginCm3 { get; set; }
        public string ApFioCm3 { get; set; }
        public string ApDepartmentCm3 { get; set; }
        public string ApPostfieldCm3 { get; set; }
        public string ApSoglasCm3 { get; set; }
        public string ApNoteCm3 { get; set; }
        public string ApLoginCc { get; set; }
        public string ApFioCc { get; set; }
        public string ApDepartmentCc { get; set; }
        public string ApPostfieldCc { get; set; }
        public string ApSoglasCc { get; set; }
        public string ApNoteCc { get; set; }
        public DateTime? ApReportDate { get; set; }
        public bool? ApScipsoglas { get; set; }
        public string HNpp { get; set; }
        public DateTime? HReportDate { get; set; }
        public string HDateText { get; set; }
        public string HInst { get; set; }
        public string HNmDept { get; set; }
        public string HAccount { get; set; }
        public string HOrderNmb { get; set; }
        public DateTime? HOrderDate { get; set; }
        public string HNmCounter { get; set; }
        public DateTime? HBeginInvDate { get; set; }
        public DateTime? HEndInvDate { get; set; }
        public string HOkud { get; set; }
        public DateTime? HDateForm { get; set; }
        public string HOkpo { get; set; }
        public string HComState { get; set; }
        public DateTime? Tbl1Date1 { get; set; }
        public DateTime? Tbl1Date2 { get; set; }
        public DateTime? Tbl1Date3 { get; set; }
        public string Nmreg { get; set; }
        public string Instcd { get; set; }
        public string PTofkCode { get; set; }
        public string Vv { get; set; }
        public string VTofk { get; set; }
        public string Vr { get; set; }

        public virtual ICollection<FsApApprovalList> FsApApprovalList { get; set; }
        public virtual ICollection<FsTbl10504082List> FsTbl10504082List { get; set; }
    }
}
