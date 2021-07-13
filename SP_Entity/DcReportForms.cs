using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class DcReportForms
    {
        public DcReportForms()
        {
            FsAnalyticalsList = new HashSet<FsAnalyticalsList>();
            FsTCsbuList = new HashSet<FsTCsbuList>();
        }

        public decimal Docid { get; set; }
        public decimal? Version { get; set; }
        public string Code { get; set; }
        public bool? Halfyear { get; set; }
        public bool? Kvartal { get; set; }
        public bool? Mounth { get; set; }
        public string Formular { get; set; }
        public string Period { get; set; }
        public string Okud { get; set; }
        public string Name { get; set; }
        public string Cdkosgu { get; set; }
        public string PrFormPrCode { get; set; }
        public string PrFormPrOkud { get; set; }
        public string PrFormPrName { get; set; }
        public string Note { get; set; }
        public bool? God { get; set; }
        public bool? Proizv { get; set; }
        public string Temp2 { get; set; }
        public string Temp1 { get; set; }
        public string Temp3 { get; set; }
        public string Temp4 { get; set; }
        public string Temp5 { get; set; }
        public DateTime? DataStartactive { get; set; }
        public DateTime? DataEndactive { get; set; }
        public string Cdaccbu { get; set; }
        public string Temp6 { get; set; }
        public string Temp7 { get; set; }
        public string Temp8 { get; set; }
        public bool? Dek { get; set; }
        public bool? Day { get; set; }
        public bool? Week { get; set; }
        public string Temp9 { get; set; }
        public bool? Reorg { get; set; }

        public virtual ICollection<FsAnalyticalsList> FsAnalyticalsList { get; set; }
        public virtual ICollection<FsTCsbuList> FsTCsbuList { get; set; }
    }
}
