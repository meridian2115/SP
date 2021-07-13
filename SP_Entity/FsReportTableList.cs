using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class FsReportTableList
    {
        public decimal? Docid { get; set; }
        public decimal? Tablerownum { get; set; }
        public decimal Fieldsetid { get; set; }
        public string NameMark { get; set; }
        public string Ksbu { get; set; }
        public string BcNumberOfEntries { get; set; }
        public string BcNumberBo { get; set; }
        public string BcCodeKofk { get; set; }
        public string BcInnContractor { get; set; }
        public decimal? BcAmount { get; set; }
        public string BcNamecontractor { get; set; }
        public string DaNumberBudgetAccount { get; set; }
        public decimal? DaTotalBy { get; set; }
        public decimal? DaOverdueBy { get; set; }
        public decimal? DaOverdueEndp { get; set; }
        public decimal? DaTotalEndp { get; set; }
        public DateTime? DaDebtOccurrenceDate { get; set; }
        public DateTime? DaLimitDate { get; set; }
        public string DaKvd { get; set; }
        public string DaCodeschet { get; set; }
        public string DaKosgu { get; set; }
        public string DaKbk { get; set; }
        public decimal? AiScheduledDebtEndp { get; set; }
        public string DorCodeDoDor { get; set; }
        public string DorExplanations { get; set; }
        public string RdrmCodeDoRdrm { get; set; }
        public string RdrmExplanationsRdrm { get; set; }
        public decimal? STotalCommitment { get; set; }
        public decimal? STotalCounterparty { get; set; }
        public decimal? STotalAmount { get; set; }
        public decimal? SIncluding { get; set; }
        public decimal? SsiSsiAmount { get; set; }
        public decimal? SsiSsiTotalBy { get; set; }
        public decimal? SsiSsiOverdueBy { get; set; }
        public decimal? SsiSsiTotalEndp { get; set; }
        public decimal? SsiSsiOverdueEndp { get; set; }
        public decimal? SsiSsiScheDebtEndp { get; set; }
        public decimal? SsoSsoAmount { get; set; }
        public decimal? SsoSsoTotalBy { get; set; }
        public decimal? SsoSsoOverdueBy { get; set; }
        public decimal? SsoSsoTotalEndp { get; set; }
        public decimal? SsoSsoOverdueEndp { get; set; }
        public decimal? SsoSsoScheDebtEndp { get; set; }
        public string Myschetchik { get; set; }
        public string Ac { get; set; }
        public string KbkType { get; set; }

        public virtual DcReport0503192 Doc { get; set; }
    }
}
