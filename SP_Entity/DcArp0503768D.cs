using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class DcArp0503768D
    {
        public DcArp0503768D()
        {
            FsInfmv19Tab455768List = new HashSet<FsInfmv19Tab455768List>();
            FsInfmv19Tab465768List = new HashSet<FsInfmv19Tab465768List>();
            FsInfmv19Tab470768List = new HashSet<FsInfmv19Tab470768List>();
            FsInfmv19Tab490768List = new HashSet<FsInfmv19Tab490768List>();
            FsInfmv19Tab512768List = new HashSet<FsInfmv19Tab512768List>();
            FsInfmv19Tab549768List = new HashSet<FsInfmv19Tab549768List>();
            FsInfmv19Tab558768List = new HashSet<FsInfmv19Tab558768List>();
            FsInfmv19Tab610768List = new HashSet<FsInfmv19Tab610768List>();
            FsInfmv19Tab660768List = new HashSet<FsInfmv19Tab660768List>();
            FsInfmv19Tab7683List = new HashSet<FsInfmv19Tab7683List>();
            FsInfmvTab1List = new HashSet<FsInfmvTab1List>();
            FsInfmvTab2List = new HashSet<FsInfmvTab2List>();
            FsInfmvTb3List = new HashSet<FsInfmvTb3List>();
            FsInfmvTb450460List = new HashSet<FsInfmvTb450460List>();
            FsNonfncTab7681List = new HashSet<FsNonfncTab7681List>();
            FsRlprtTab7682List = new HashSet<FsRlprtTab7682List>();
        }

        public decimal Docid { get; set; }
        public decimal? Version { get; set; }
        public string Nameseparatedivision { get; set; }
        public string Codeseparatedivision { get; set; }
        public string Namefounder { get; set; }
        public string Codefounder { get; set; }
        public string Namebodyactingfounder { get; set; }
        public string Codebodyactingfounder { get; set; }
        public decimal? InfmvCountertab1 { get; set; }
        public decimal? InfmvCountertab2 { get; set; }
        public string PenCentraccCode { get; set; }
        public string PenCentraccName { get; set; }
        public string PenCentraccOgrn { get; set; }
        public string PenCentraccInn { get; set; }
        public string PenCentraccKpp { get; set; }
        public string PenCentraccLdr { get; set; }
        public string PenCentraccExec { get; set; }
        public string PenCentraccExecm { get; set; }
        public string PenCentraccLdr1 { get; set; }
        public string PenCentraccExec1 { get; set; }
        public string PenCentraccAddress { get; set; }
        public string PenPfnLeader { get; set; }
        public string PenPfnChiefAcc { get; set; }
        public string PenPfnLeaderOfFes { get; set; }
        public string PenPfnPostLeader { get; set; }
        public string PenPfnPostChiefAcc { get; set; }
        public string PenPfnPostLeaderOf { get; set; }
        public string PenPfnExecutor { get; set; }
        public string PenPfnPostExecutor { get; set; }
        public string PenPfnPhone { get; set; }
        public string PenPostLeaderOfFes { get; set; }
        public bool? SubDiv { get; set; }
        public string ReportBaseErOkpo1 { get; set; }
        public string Ord { get; set; }
        public string Surrogat { get; set; }

        public virtual ICollection<FsInfmv19Tab455768List> FsInfmv19Tab455768List { get; set; }
        public virtual ICollection<FsInfmv19Tab465768List> FsInfmv19Tab465768List { get; set; }
        public virtual ICollection<FsInfmv19Tab470768List> FsInfmv19Tab470768List { get; set; }
        public virtual ICollection<FsInfmv19Tab490768List> FsInfmv19Tab490768List { get; set; }
        public virtual ICollection<FsInfmv19Tab512768List> FsInfmv19Tab512768List { get; set; }
        public virtual ICollection<FsInfmv19Tab549768List> FsInfmv19Tab549768List { get; set; }
        public virtual ICollection<FsInfmv19Tab558768List> FsInfmv19Tab558768List { get; set; }
        public virtual ICollection<FsInfmv19Tab610768List> FsInfmv19Tab610768List { get; set; }
        public virtual ICollection<FsInfmv19Tab660768List> FsInfmv19Tab660768List { get; set; }
        public virtual ICollection<FsInfmv19Tab7683List> FsInfmv19Tab7683List { get; set; }
        public virtual ICollection<FsInfmvTab1List> FsInfmvTab1List { get; set; }
        public virtual ICollection<FsInfmvTab2List> FsInfmvTab2List { get; set; }
        public virtual ICollection<FsInfmvTb3List> FsInfmvTb3List { get; set; }
        public virtual ICollection<FsInfmvTb450460List> FsInfmvTb450460List { get; set; }
        public virtual ICollection<FsNonfncTab7681List> FsNonfncTab7681List { get; set; }
        public virtual ICollection<FsRlprtTab7682List> FsRlprtTab7682List { get; set; }
    }
}
