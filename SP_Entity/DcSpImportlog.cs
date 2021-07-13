using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class DcSpImportlog
    {
        public DcSpImportlog()
        {
            FsErrorsTabCommentList = new HashSet<FsErrorsTabCommentList>();
            FsErrorsTabList = new HashSet<FsErrorsTabList>();
            FsErrorsTabTmpList = new HashSet<FsErrorsTabTmpList>();
        }

        public decimal Docid { get; set; }
        public decimal? Version { get; set; }
        public string HrFormname { get; set; }
        public bool? HrChangeinlow { get; set; }
        public string HrSysformname { get; set; }
        public string HrPeriod { get; set; }
        public string HrYear { get; set; }
        public string DataversionDatavers { get; set; }
        public string DataversionVersionname { get; set; }
        public DateTime? DataversionLastupdate { get; set; }
        public string Versionupdoptions { get; set; }
        public string HrImportformat { get; set; }
        public bool? HrPed { get; set; }
        public string Errortext { get; set; }
        public string ContrlState { get; set; }
        public string Login { get; set; }
        public string Errorname { get; set; }
        public string Stateidc { get; set; }
        public string Statebdc { get; set; }
        public string Stateflc { get; set; }

        public virtual ICollection<FsErrorsTabCommentList> FsErrorsTabCommentList { get; set; }
        public virtual ICollection<FsErrorsTabList> FsErrorsTabList { get; set; }
        public virtual ICollection<FsErrorsTabTmpList> FsErrorsTabTmpList { get; set; }
    }
}
