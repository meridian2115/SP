using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class DcArpReport0503074
    {
        public DcArpReport0503074()
        {
            FsATyperep074List = new HashSet<FsATyperep074List>();
            FsCategcarT7List = new HashSet<FsCategcarT7List>();
            FsCategcostcarT9List = new HashSet<FsCategcostcarT9List>();
            FsCostscarT8List = new HashSet<FsCostscarT8List>();
            FsExpsbT1List = new HashSet<FsExpsbT1List>();
            FsFedbudexpT5List = new HashSet<FsFedbudexpT5List>();
            FsNumcarT4List = new HashSet<FsNumcarT4List>();
            FsNumsbT3List = new HashSet<FsNumsbT3List>();
            FsPostnumT2List = new HashSet<FsPostnumT2List>();
            FsTypeterT6List = new HashSet<FsTypeterT6List>();
        }

        public decimal Docid { get; set; }
        public decimal? Version { get; set; }
        public string HrTypeterritorial { get; set; }
        public decimal? HrWorkerlimit { get; set; }
        public string HrOktmo { get; set; }
        public string HrTyperep { get; set; }
        public string HrRegion { get; set; }
        public DateTime? HrDateCheck { get; set; }
        public string ExpsbC1R11 { get; set; }
        public string ExpsbC1R12 { get; set; }
        public string ExpsbC1R13 { get; set; }
        public string PostnumC1R21 { get; set; }
        public string PostnumC1R22 { get; set; }
        public string PostnumC1R23 { get; set; }
        public string NumsbC1R31 { get; set; }
        public string NumsbC1R32 { get; set; }
        public string NumsbC1R33 { get; set; }
        public string NumcarC1R41 { get; set; }
        public string NumcarC1R42 { get; set; }
        public string NumcarC1R43 { get; set; }
        public string CategcarC1R41 { get; set; }
        public string CategcarC1R42 { get; set; }
        public string CategcarC1R43 { get; set; }
        public string CostscarC1R41 { get; set; }
        public string CostscarC1R42 { get; set; }
        public string CostscarC1R43 { get; set; }
        public string CategcostcarC1R41 { get; set; }
        public string CategcostcarC1R42 { get; set; }
        public string CategcostcarC1R43 { get; set; }
        public string SigPfnLeader { get; set; }
        public string SigPfnChiefAcc { get; set; }
        public string SigPfnLeaderOfFes { get; set; }
        public string SigPfnPostLeader { get; set; }
        public string SigPfnPostChiefAcc { get; set; }
        public string SigPfnPostLeaderOf { get; set; }
        public string SigPfnExecutor { get; set; }
        public string SigPfnPostExecutor { get; set; }
        public string SigPfnPhone { get; set; }
        public string SigTelephone { get; set; }
        public string AOrd { get; set; }

        public virtual ICollection<FsATyperep074List> FsATyperep074List { get; set; }
        public virtual ICollection<FsCategcarT7List> FsCategcarT7List { get; set; }
        public virtual ICollection<FsCategcostcarT9List> FsCategcostcarT9List { get; set; }
        public virtual ICollection<FsCostscarT8List> FsCostscarT8List { get; set; }
        public virtual ICollection<FsExpsbT1List> FsExpsbT1List { get; set; }
        public virtual ICollection<FsFedbudexpT5List> FsFedbudexpT5List { get; set; }
        public virtual ICollection<FsNumcarT4List> FsNumcarT4List { get; set; }
        public virtual ICollection<FsNumsbT3List> FsNumsbT3List { get; set; }
        public virtual ICollection<FsPostnumT2List> FsPostnumT2List { get; set; }
        public virtual ICollection<FsTypeterT6List> FsTypeterT6List { get; set; }
    }
}
