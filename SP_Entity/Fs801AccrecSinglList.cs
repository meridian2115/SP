using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class Fs801AccrecSinglList
    {
        public decimal Fieldsetid { get; set; }
        public decimal? Tablerownum { get; set; }
        public decimal? Docid { get; set; }
        public decimal? AccountedAmount { get; set; }
        public string OperationName { get; set; }
        public string LedgerId { get; set; }
        public string LedgerName { get; set; }
        public DateTime? TransactionDate { get; set; }
        public string BudgetCode { get; set; }
        public string FundActivities { get; set; }
        public string OperationType { get; set; }
        public string OperationCode { get; set; }
        public string PTofkCode { get; set; }
        public string DrBuhAccount { get; set; }
        public string DrAccount { get; set; }
        public string DrPa { get; set; }
        public string DrBankPa { get; set; }
        public string DrBudget { get; set; }
        public string DrBccType { get; set; }
        public string DrBcc { get; set; }
        public string DrFundSourceCode { get; set; }
        public string DrFundSourceName { get; set; }
        public string DrPaActivities { get; set; }
        public string DrPaActivitiesName { get; set; }
        public string DrFundActivitiesCode { get; set; }
        public string DrTofkCode { get; set; }
        public string DrSegmentCode { get; set; }
        public string DrBoNum { get; set; }
        public string DrOktmo { get; set; }
        public string DrChangeCode { get; set; }
        public string DrCloseFlag { get; set; }
        public string DrFaipCode { get; set; }
        public string DrKmiCode { get; set; }
        public string DrFoCode { get; set; }
        public string DrChildCode { get; set; }
        public string DrSubsidyTargets { get; set; }
        public string DrSegmentName { get; set; }
        public string DrDoNum { get; set; }
        public string DrBccTypeName { get; set; }
        public string CrBuhAccount { get; set; }
        public string CrAccount { get; set; }
        public string CrPa { get; set; }
        public string CrBankPa { get; set; }
        public string CrBudget { get; set; }
        public string CrBccType { get; set; }
        public string CrBcc { get; set; }
        public string CrFundSourceCode { get; set; }
        public string CrFundSourceName { get; set; }
        public string CrPaActivities { get; set; }
        public string CrPaActivitiesName { get; set; }
        public string CrFundActivitiesCode { get; set; }
        public string CrTofkCode { get; set; }
        public string CrSegmentCode { get; set; }
        public string CrBoNum { get; set; }
        public string CrOktmo { get; set; }
        public string CrChangeCode { get; set; }
        public string CrCloseFlag { get; set; }
        public string CrFaipCode { get; set; }
        public string CrKmiCode { get; set; }
        public string CrFoCode { get; set; }
        public string CrChildCode { get; set; }
        public string CrSubsidyTargets { get; set; }
        public string CrSegmentName { get; set; }
        public string CrDoNum { get; set; }
        public string CrBccTypeName { get; set; }
        public string StatusDescription { get; set; }
        public string CloseFlag { get; set; }
        public string CurrencyName { get; set; }
        public string CurrencyCode { get; set; }
        public string AccountD { get; set; }
        public string AccountC { get; set; }
        public string Namedo { get; set; }
        public decimal? EnteredAmount { get; set; }
        public DateTime? EffectiveDate { get; set; }
        public string DrOperAccount { get; set; }
        public string CrOperAccount { get; set; }
        public string Period { get; set; }

        public virtual DcMscApplcashflow Doc { get; set; }
    }
}
