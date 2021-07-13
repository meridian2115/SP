using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class DcReport0503164
    {
        public DcReport0503164()
        {
            FsBeExpense164List = new HashSet<FsBeExpense164List>();
            FsBrRevenue164List = new HashSet<FsBrRevenue164List>();
            FsSfDomestic164List = new HashSet<FsSfDomestic164List>();
            FsSfExternal164List = new HashSet<FsSfExternal164List>();
        }

        public decimal Docid { get; set; }
        public decimal? Version { get; set; }
        public string Surrogat { get; set; }
        public string PfnLeader { get; set; }
        public string PfnChiefAcc { get; set; }
        public string PfnLeaderOfFes { get; set; }
        public string PfnPostLeader { get; set; }
        public string PfnPostChiefAcc { get; set; }
        public string PfnPostLeaderOf { get; set; }
        public string PfnExecutor { get; set; }
        public string PfnPostExecutor { get; set; }
        public string PfnPhone { get; set; }
        public decimal? BrC3R010 { get; set; }
        public decimal? BrC5R010 { get; set; }
        public decimal? BrC4R010 { get; set; }
        public decimal? BrC6R010 { get; set; }
        public decimal? BrC4R010N { get; set; }
        public decimal? SfC3R500 { get; set; }
        public decimal? SfC4R500 { get; set; }
        public decimal? SfC5R500 { get; set; }
        public decimal? SfC6R500 { get; set; }
        public decimal? SfC4R500N { get; set; }
        public decimal? SfC7R500N { get; set; }
        public decimal? SfC3R520 { get; set; }
        public decimal? SfC4R520 { get; set; }
        public decimal? SfC5R520 { get; set; }
        public decimal? SfC6R520 { get; set; }
        public decimal? SfC4R520N { get; set; }
        public decimal? SfC3R620 { get; set; }
        public decimal? SfC4R620 { get; set; }
        public decimal? SfC5R620 { get; set; }
        public decimal? SfC6R620 { get; set; }
        public decimal? SfC4R620N { get; set; }
        public decimal? BeC3R200 { get; set; }
        public decimal? BeC4R200 { get; set; }
        public decimal? BeC5R200 { get; set; }
        public decimal? BeC6R200 { get; set; }
        public decimal? BeC4R200N { get; set; }
        public decimal? BePercent { get; set; }
        public string BeLogOperator { get; set; }
        public decimal? BeNotexecuted { get; set; }
        public decimal? BeOutcomeC5R450 { get; set; }
        public decimal? BeOutcomeC4R450N { get; set; }
        public DateTime? VData { get; set; }
        public string VPeriodName { get; set; }
        public bool? C3R0101Cabr { get; set; }
        public string Ord { get; set; }
        public string Namtip { get; set; }
        public string Subotch { get; set; }
        public decimal? Year { get; set; }

        public virtual ICollection<FsBeExpense164List> FsBeExpense164List { get; set; }
        public virtual ICollection<FsBrRevenue164List> FsBrRevenue164List { get; set; }
        public virtual ICollection<FsSfDomestic164List> FsSfDomestic164List { get; set; }
        public virtual ICollection<FsSfExternal164List> FsSfExternal164List { get; set; }
    }
}
