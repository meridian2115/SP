using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class DcArpStatpredotch
    {
        public DcArpStatpredotch()
        {
            FsT1StatList = new HashSet<FsT1StatList>();
            FsT2StatList = new HashSet<FsT2StatList>();
            FsT3StatList = new HashSet<FsT3StatList>();
        }

        public decimal Docid { get; set; }
        public decimal? Version { get; set; }
        public string OrgCode { get; set; }
        public DateTime? Datefororders2 { get; set; }
        public decimal? Sumnumbcorr { get; set; }
        public string PeriodTypeC { get; set; }
        public DateTime? ReportDateC { get; set; }
        public string NameOfEntityC { get; set; }
        public string SubotchC { get; set; }
        public string TypeForm { get; set; }
        public string StartForm { get; set; }
        public string TofkNm { get; set; }
        public string TofkCd { get; set; }
        public string TypesSub { get; set; }
        public bool? Flag191n { get; set; }
        public bool? Flag33n { get; set; }
        public string BkCodes { get; set; }
        public bool? FlagNotification { get; set; }

        public virtual ICollection<FsT1StatList> FsT1StatList { get; set; }
        public virtual ICollection<FsT2StatList> FsT2StatList { get; set; }
        public virtual ICollection<FsT3StatList> FsT3StatList { get; set; }
    }
}
