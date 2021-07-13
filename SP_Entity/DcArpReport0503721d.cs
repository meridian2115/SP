using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class DcArpReport0503721d
    {
        public DcArpReport0503721d()
        {
            FsBeTab721BeDList = new HashSet<FsBeTab721BeDList>();
            FsBrTab721BrDList = new HashSet<FsBrTab721BrDList>();
            FsOfaTab721faDList = new HashSet<FsOfaTab721faDList>();
        }

        public decimal Docid { get; set; }
        public decimal? Version { get; set; }
        public string Surrogat { get; set; }
        public bool? Subdiv { get; set; }
        public string HrNamtip { get; set; }
        public string HrTypesubotch { get; set; }
        public string Ord { get; set; }
        public string Nameseparatedivision { get; set; }
        public string Codeseparatedivision { get; set; }
        public string Namefounder { get; set; }
        public string Codefounder { get; set; }
        public string Namebodyactingfounder { get; set; }
        public string Codebodyactingfounder { get; set; }
        public string PenPfnLeader { get; set; }
        public string PenPfnChiefAcc { get; set; }
        public string PenPfnLeaderOfFes { get; set; }
        public string PenPfnPostLeader { get; set; }
        public string PenPfnPostChiefAcc { get; set; }
        public string PenPfnPostLeaderOf { get; set; }
        public string PenPfnExecutor { get; set; }
        public string PenPfnPostExecutor { get; set; }
        public string PenPfnPhone { get; set; }
        public string PenCentraccCode { get; set; }
        public string PenCentraccName { get; set; }
        public string PenCentraccOgrn { get; set; }
        public string PenCentraccInn { get; set; }
        public string PenCentraccKpp { get; set; }
        public string PenCentraccAddress { get; set; }
        public string PenCentraccLdr { get; set; }
        public string PenCentraccExec { get; set; }
        public string PenCentraccLdr1 { get; set; }
        public string PenCentraccExec1 { get; set; }
        public string PenCentraccExecm { get; set; }
        public string PenExecuter { get; set; }
        public string PenPostExec { get; set; }
        public string ReportBaseErOkpo1 { get; set; }
        public string Innfounder { get; set; }

        public virtual ICollection<FsBeTab721BeDList> FsBeTab721BeDList { get; set; }
        public virtual ICollection<FsBrTab721BrDList> FsBrTab721BrDList { get; set; }
        public virtual ICollection<FsOfaTab721faDList> FsOfaTab721faDList { get; set; }
    }
}
