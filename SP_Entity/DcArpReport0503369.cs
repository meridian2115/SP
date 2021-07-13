using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class DcArpReport0503369
    {
        public DcArpReport0503369()
        {
            FsCd40T40List = new HashSet<FsCd40T40List>();
            FsCd60T60List = new HashSet<FsCd60T60List>();
            FsTb0503369ItogoList = new HashSet<FsTb0503369ItogoList>();
            FsTb0503369List = new HashSet<FsTb0503369List>();
        }

        public decimal Docid { get; set; }
        public decimal? Version { get; set; }
        public string HrPnfLeader { get; set; }
        public string HrPnfChiefAcc { get; set; }
        public string HrPnfLeaderOfFes { get; set; }
        public string HrPnfPostLeader { get; set; }
        public string HrPnfPostChiefAcc { get; set; }
        public string HrPnfPostLeaderOf { get; set; }
        public string HrPnfExecutor { get; set; }
        public string HrPnfPostExecutor { get; set; }
        public string HrPnfPhone { get; set; }
        public string HrOrd { get; set; }
        public string HrNamtip { get; set; }
        public decimal? C2Itog { get; set; }
        public decimal? C3Itog { get; set; }
        public decimal? C4Itog { get; set; }
        public decimal? C5Itog { get; set; }
        public DateTime? Dateminusday { get; set; }
        public DateTime? Year { get; set; }
        public decimal? Cd40C2Itog { get; set; }
        public decimal? Cd40C3Itog { get; set; }
        public decimal? Cd40C4Itog { get; set; }
        public decimal? Cd40C5Itog { get; set; }
        public decimal? Cd60C2Itog { get; set; }
        public decimal? Cd60C3Itog { get; set; }
        public decimal? Cd60C4Itog { get; set; }
        public decimal? Cd60C5Itog { get; set; }

        public virtual ICollection<FsCd40T40List> FsCd40T40List { get; set; }
        public virtual ICollection<FsCd60T60List> FsCd60T60List { get; set; }
        public virtual ICollection<FsTb0503369ItogoList> FsTb0503369ItogoList { get; set; }
        public virtual ICollection<FsTb0503369List> FsTb0503369List { get; set; }
    }
}
