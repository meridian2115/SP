using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class DcArpReport0503830D
    {
        public DcArpReport0503830D()
        {
            FsBa19T0400503830dList = new HashSet<FsBa19T0400503830dList>();
            FsBa19T2000503830dList = new HashSet<FsBa19T2000503830dList>();
            FsBa19T30503830dList = new HashSet<FsBa19T30503830dList>();
            FsBaT0100503830dList = new HashSet<FsBaT0100503830dList>();
            FsBaT0200503830dList = new HashSet<FsBaT0200503830dList>();
            FsBaT0300503830dList = new HashSet<FsBaT0300503830dList>();
            FsBaT0400503830dList = new HashSet<FsBaT0400503830dList>();
            FsBaT0500503830dList = new HashSet<FsBaT0500503830dList>();
            FsBaT1200503830dList = new HashSet<FsBaT1200503830dList>();
            FsBaT2000503830dList = new HashSet<FsBaT2000503830dList>();
            FsBaT2100503830dList = new HashSet<FsBaT2100503830dList>();
            FsBaT2200503830dList = new HashSet<FsBaT2200503830dList>();
            FsBaT2300503830dList = new HashSet<FsBaT2300503830dList>();
            FsBaT2500503830dList = new HashSet<FsBaT2500503830dList>();
            FsBaT2600503830dList = new HashSet<FsBaT2600503830dList>();
            FsBaT30503830dList = new HashSet<FsBaT30503830dList>();
            FsT10503830dList = new HashSet<FsT10503830dList>();
            FsT20503830dList = new HashSet<FsT20503830dList>();
        }

        public decimal Docid { get; set; }
        public decimal? Version { get; set; }
        public string HrNameseparatedivision { get; set; }
        public string HrCodeseparatedivision { get; set; }
        public string HrNamehomeorg { get; set; }
        public string HrCodehomeorg { get; set; }
        public string HrNamefounder { get; set; }
        public string HrCodefounder { get; set; }
        public string HrNamebodyactingfounder { get; set; }
        public string HrCodebodyactingfounder { get; set; }
        public string HrReorgRepor { get; set; }
        public string HrReorgReporKod { get; set; }
        public string HrReorgGlavaBk { get; set; }
        public string HrOkpo1 { get; set; }
        public string HrInn1 { get; set; }
        public bool? HrFoundercheck { get; set; }
        public string BaCountsum010 { get; set; }
        public string BaCountsum020 { get; set; }
        public string BaCountsum030 { get; set; }
        public string BaCountsum040 { get; set; }
        public string BaCountsum050 { get; set; }
        public string BaCountsum120 { get; set; }
        public string BaCountsum200 { get; set; }
        public string BaCountsum210 { get; set; }
        public string BaCountsum220 { get; set; }
        public string BaCountsum230 { get; set; }
        public string BaCountsum250 { get; set; }
        public string BaCountsum260 { get; set; }
        public string Ba19Countsum040 { get; set; }
        public string Ba19Countsum200 { get; set; }
        public string CentraccCode { get; set; }
        public string CentraccName { get; set; }
        public string CentraccOgrn { get; set; }
        public string CentraccInn { get; set; }
        public string CentraccKpp { get; set; }
        public string CentraccLocation { get; set; }
        public string Surrogat { get; set; }
        public string CaLeader { get; set; }
        public string CaExecutor { get; set; }
        public string CaLeader1 { get; set; }
        public string CaExecutor1 { get; set; }
        public string CaExecutorMail { get; set; }
        public string ReorgNameGlava { get; set; }
        public string ReorgGlavaBk { get; set; }
        public decimal? NullValue { get; set; }
        public string TelIsp { get; set; }
        public string Ord { get; set; }
        public string PenLeader { get; set; }
        public string PenChiefAcc { get; set; }
        public string PenLeaderOfFes { get; set; }
        public string PenPostLeader { get; set; }
        public string PenPostChiefAcc { get; set; }
        public string PenPostLeaderOf { get; set; }
        public string PenExecutor { get; set; }
        public string PenPostExecutor { get; set; }
        public string PenPhone { get; set; }

        public virtual ICollection<FsBa19T0400503830dList> FsBa19T0400503830dList { get; set; }
        public virtual ICollection<FsBa19T2000503830dList> FsBa19T2000503830dList { get; set; }
        public virtual ICollection<FsBa19T30503830dList> FsBa19T30503830dList { get; set; }
        public virtual ICollection<FsBaT0100503830dList> FsBaT0100503830dList { get; set; }
        public virtual ICollection<FsBaT0200503830dList> FsBaT0200503830dList { get; set; }
        public virtual ICollection<FsBaT0300503830dList> FsBaT0300503830dList { get; set; }
        public virtual ICollection<FsBaT0400503830dList> FsBaT0400503830dList { get; set; }
        public virtual ICollection<FsBaT0500503830dList> FsBaT0500503830dList { get; set; }
        public virtual ICollection<FsBaT1200503830dList> FsBaT1200503830dList { get; set; }
        public virtual ICollection<FsBaT2000503830dList> FsBaT2000503830dList { get; set; }
        public virtual ICollection<FsBaT2100503830dList> FsBaT2100503830dList { get; set; }
        public virtual ICollection<FsBaT2200503830dList> FsBaT2200503830dList { get; set; }
        public virtual ICollection<FsBaT2300503830dList> FsBaT2300503830dList { get; set; }
        public virtual ICollection<FsBaT2500503830dList> FsBaT2500503830dList { get; set; }
        public virtual ICollection<FsBaT2600503830dList> FsBaT2600503830dList { get; set; }
        public virtual ICollection<FsBaT30503830dList> FsBaT30503830dList { get; set; }
        public virtual ICollection<FsT10503830dList> FsT10503830dList { get; set; }
        public virtual ICollection<FsT20503830dList> FsT20503830dList { get; set; }
    }
}
