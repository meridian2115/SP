using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class DcReport0503125
    {
        public DcReport0503125()
        {
            FsTsAccNumberList = new HashSet<FsTsAccNumberList>();
            FsTsConsLnList = new HashSet<FsTsConsLnList>();
            FsTsMTransList = new HashSet<FsTsMTransList>();
            FsTsNmTransList = new HashSet<FsTsNmTransList>();
        }

        public decimal Docid { get; set; }
        public decimal? Version { get; set; }
        public string HrTypeactivityname { get; set; }
        public string HrTypeactivitycode { get; set; }
        public string HrAcctCd { get; set; }
        public string HrCsmocckieCd { get; set; }
        public string HrNamtip { get; set; }
        public string HrSubotch { get; set; }
        public string HrInn { get; set; }
        public decimal? TsConsLnTtlC7RTtl { get; set; }
        public decimal? TsConsLnTtlC8RTtl { get; set; }
        public decimal? TsConsLnTtlC7SumTmp { get; set; }
        public decimal? TsConsLnTtlC8SumTmp { get; set; }
        public decimal? TsConsLnTtlC7TotalTmp { get; set; }
        public decimal? TsConsLnTtlC8TotalTmp { get; set; }
        public string PfnPfnLeader { get; set; }
        public string PfnPfnChiefAcc { get; set; }
        public string PfnPfnLeaderOfFes { get; set; }
        public string PfnPfnPostLeader { get; set; }
        public string PfnPfnPostChiefAcc { get; set; }
        public string PfnPfnPostLeaderOf { get; set; }
        public string PfnPfnExecutor { get; set; }
        public string PfnPfnPostExecutor { get; set; }
        public string PfnPfnPhone { get; set; }
        public string PfnExecutorTel { get; set; }
        public string System { get; set; }
        public string System1 { get; set; }
        public string Ord { get; set; }

        public virtual ICollection<FsTsAccNumberList> FsTsAccNumberList { get; set; }
        public virtual ICollection<FsTsConsLnList> FsTsConsLnList { get; set; }
        public virtual ICollection<FsTsMTransList> FsTsMTransList { get; set; }
        public virtual ICollection<FsTsNmTransList> FsTsNmTransList { get; set; }
    }
}
