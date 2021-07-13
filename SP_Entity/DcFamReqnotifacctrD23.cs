using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class DcFamReqnotifacctrD23
    {
        public DcFamReqnotifacctrD23()
        {
            FsLaAgrD23List = new HashSet<FsLaAgrD23List>();
            FsLaAppD23List = new HashSet<FsLaAppD23List>();
            FsLaExecD23List = new HashSet<FsLaExecD23List>();
            FsOebsErrorsD23List = new HashSet<FsOebsErrorsD23List>();
        }

        public decimal Docid { get; set; }
        public decimal? Version { get; set; }
        public string HrStatus { get; set; }
        public bool? HrPolucheno { get; set; }
        public string HrCreateorg { get; set; }
        public string IfzReqnum { get; set; }
        public DateTime? IfzReqdate { get; set; }
        public string IfzReqcreator { get; set; }
        public string IfzReqrecipient { get; set; }
        public string IfzReqview { get; set; }
        public string IfzReqviewnm { get; set; }
        public string IfzTehpole { get; set; }
        public string IfzDocguid { get; set; }
        public DateTime? IzvDate1 { get; set; }
        public string IzvBik { get; set; }
        public string IzvNumreis { get; set; }
        public string IzvAccnum { get; set; }
        public DateTime? IzvBeginperiod { get; set; }
        public DateTime? IzvEndperiod { get; set; }
        public string ErCodeer { get; set; }
        public string ErTexter { get; set; }
        public string ErClobfield { get; set; }
        public string Scadcdstat { get; set; }
        public string Scadnmstat { get; set; }
        public string Guidvip { get; set; }
        public bool? LaSkipappr { get; set; }
        public string LaAmountrowexecutor { get; set; }
        public string LaAmountrowagreer { get; set; }
        public string LaAmountrowapprover { get; set; }
        public string TfClobfield { get; set; }
        public string TfTofkcode { get; set; }
        public string TfTofkname { get; set; }
        public string TfBusinessStatus { get; set; }
        public string TfReturnstatuscreate { get; set; }
        public string TfReturnstatusexec { get; set; }

        public virtual ICollection<FsLaAgrD23List> FsLaAgrD23List { get; set; }
        public virtual ICollection<FsLaAppD23List> FsLaAppD23List { get; set; }
        public virtual ICollection<FsLaExecD23List> FsLaExecD23List { get; set; }
        public virtual ICollection<FsOebsErrorsD23List> FsOebsErrorsD23List { get; set; }
    }
}
