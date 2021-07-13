using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class FsResultList
    {
        public decimal? Docid { get; set; }
        public decimal? Tablerownum { get; set; }
        public decimal Fieldsetid { get; set; }
        public string DkDocNum { get; set; }
        public string DkGuid { get; set; }
        public string DkDocDate { get; set; }
        public string DkDocType { get; set; }
        public string DoDocDate { get; set; }
        public string DoDocNum { get; set; }
        public string DrBuhAccount { get; set; }
        public string CrBuhAccount { get; set; }
        public decimal? AccountedSumma { get; set; }
        public string OperationName { get; set; }
        public string DocType { get; set; }
        public string DocGroup { get; set; }
        public decimal? LedgerId { get; set; }
        public DateTime? TransactionDate { get; set; }
        public string BudgetCode { get; set; }
        public string FundActivities { get; set; }
        public string DrAccount { get; set; }
        public string CrAccount { get; set; }
        public string DrBcc { get; set; }
        public string CrBcc { get; set; }
        public string OperationType { get; set; }
        public string DrPa { get; set; }
        public string CrPa { get; set; }
        public string DrBankPa { get; set; }
        public string CrBankPa { get; set; }
        public string DrBccType { get; set; }
        public string CrBccType { get; set; }
        public string DoGuid { get; set; }
        public string DoDocType { get; set; }
        public string PTofkCode { get; set; }
        public string Doctypef { get; set; }
        public DateTime? Datado { get; set; }
        public string DoDocName { get; set; }
        public string DrBudget { get; set; }
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
        public string CrBudget { get; set; }
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
        public string BusinessStatus { get; set; }
        public string CloseFlag { get; set; }
        public string CurrencyName { get; set; }
        public string CurrencyCode { get; set; }
        public string Period { get; set; }

        public virtual DcArpFahPosting Doc { get; set; }
    }
}
