using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class DcArpReport05030742018
    {
        public DcArpReport05030742018()
        {
            FsATyperep074List2 = new HashSet<FsATyperep074List2>();
            FsCatcostcarT9List2 = new HashSet<FsCatcostcarT9List2>();
            FsCategcarT7List2 = new HashSet<FsCategcarT7List2>();
            FsCostscarT8List2 = new HashSet<FsCostscarT8List2>();
            FsExpnumworT11R7List = new HashSet<FsExpnumworT11R7List>();
            FsExpsbT1List2 = new HashSet<FsExpsbT1List2>();
            FsFedbudexpT5List2 = new HashSet<FsFedbudexpT5List2>();
            FsNumcarT4List2 = new HashSet<FsNumcarT4List2>();
            FsNumsbT3List2 = new HashSet<FsNumsbT3List2>();
            FsPayrefT10R4List = new HashSet<FsPayrefT10R4List>();
            FsPostnumT2List2 = new HashSet<FsPostnumT2List2>();
            FsTypeterT6List2 = new HashSet<FsTypeterT6List2>();
        }

        public decimal Docid { get; set; }
        public decimal? Version { get; set; }
        public string HrTypeterritorial { get; set; }
        public decimal? HrWorkerlimit { get; set; }
        public string HrOktmo { get; set; }
        public string HrTyperep { get; set; }
        public string HrRegion { get; set; }
        public DateTime? HrDateCheck { get; set; }
        public string HrRegionTo { get; set; }
        public string ExpsbC1R11 { get; set; }
        public string ExpsbRzpr1 { get; set; }
        public string ExpsbCstVr1 { get; set; }
        public string ExpsbKstr1 { get; set; }
        public string ExpsbC1R12 { get; set; }
        public string ExpsbRzpr2 { get; set; }
        public string ExpsbCstVr2 { get; set; }
        public string ExpsbKstr2 { get; set; }
        public string ExpsbC1R13 { get; set; }
        public string ExpsbRzpr3 { get; set; }
        public string ExpsbCstVr3 { get; set; }
        public string ExpsbKstr3 { get; set; }
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
        public string PayrefC1R41N { get; set; }
        public string PayrefC1R42N { get; set; }
        public string PayrefC1R43N { get; set; }
        public string Dd { get; set; }
        public string Mm { get; set; }
        public string Ddmm { get; set; }

        public virtual ICollection<FsATyperep074List2> FsATyperep074List2 { get; set; }
        public virtual ICollection<FsCatcostcarT9List2> FsCatcostcarT9List2 { get; set; }
        public virtual ICollection<FsCategcarT7List2> FsCategcarT7List2 { get; set; }
        public virtual ICollection<FsCostscarT8List2> FsCostscarT8List2 { get; set; }
        public virtual ICollection<FsExpnumworT11R7List> FsExpnumworT11R7List { get; set; }
        public virtual ICollection<FsExpsbT1List2> FsExpsbT1List2 { get; set; }
        public virtual ICollection<FsFedbudexpT5List2> FsFedbudexpT5List2 { get; set; }
        public virtual ICollection<FsNumcarT4List2> FsNumcarT4List2 { get; set; }
        public virtual ICollection<FsNumsbT3List2> FsNumsbT3List2 { get; set; }
        public virtual ICollection<FsPayrefT10R4List> FsPayrefT10R4List { get; set; }
        public virtual ICollection<FsPostnumT2List2> FsPostnumT2List2 { get; set; }
        public virtual ICollection<FsTypeterT6List2> FsTypeterT6List2 { get; set; }
    }
}
