using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class FsReportTable193List
    {
        public decimal? Docid { get; set; }
        public decimal? Tablerownum { get; set; }
        public decimal Fieldsetid { get; set; }
        public string NameChirt { get; set; }
        public string BcNumberBo { get; set; }
        public string BcCodeKofk { get; set; }
        public string BcInnContractor { get; set; }
        public decimal? BcAmount { get; set; }
        public string DaNumacc { get; set; }
        public string DaNewcell { get; set; }
        public string DaFullkbk { get; set; }
        public string DaKppv { get; set; }
        public string DaKvfo { get; set; }
        public string DaAccbu { get; set; }
        public string DaKosgu { get; set; }
        public decimal? ByTotalBy { get; set; }
        public decimal? ByOverdueBy { get; set; }
        public decimal? EpTotalEndp { get; set; }
        public decimal? ChConfnf { get; set; }
        public decimal? ChArrears { get; set; }
        public decimal? ChRepayfb { get; set; }
        public DateTime? DaOccurdate { get; set; }
        public DateTime? DaLimitDate { get; set; }
        public string DaCdbu { get; set; }
        public string DaKbkType { get; set; }
        public decimal? AiScheduledDebtEndp { get; set; }
        public string DorCodeDoDor { get; set; }
        public string DorExplanations { get; set; }
        public string RdrmCodeDoRdrm { get; set; }
        public string RdrmExplanationsRdrm { get; set; }
        public decimal? Schetchik { get; set; }
        public decimal? SsiSsiAmount { get; set; }
        public decimal? SsiSsiTotalBy { get; set; }
        public decimal? SsiSsiOverdueBy { get; set; }
        public decimal? SsiSsiTotalEndp { get; set; }
        public decimal? SsiSsiOverdueEndp { get; set; }
        public decimal? SsiSsiScheDebtEndp { get; set; }
        public decimal? SsiSsiConfnf { get; set; }
        public decimal? SsiSsiArrears { get; set; }
        public decimal? SsiSsiRepayfb { get; set; }
        public decimal? SsoSsoAmount { get; set; }
        public decimal? SsoSsoTotalBy { get; set; }
        public decimal? SsoSsoOverdueBy { get; set; }
        public decimal? SsoSsoTotalEndp { get; set; }
        public decimal? SsoSsoOverdueEndp { get; set; }
        public decimal? SsoSsoScheDebtEndp { get; set; }
        public decimal? SsoSsoConfnf { get; set; }
        public decimal? SsoSsoArrears { get; set; }
        public decimal? SsoSsoRepayfb { get; set; }
        public string Namecont2 { get; set; }

        public virtual DcReport0503193 Doc { get; set; }
    }
}
