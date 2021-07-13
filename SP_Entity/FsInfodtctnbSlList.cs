using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class FsInfodtctnbSlList
    {
        public decimal? Docid { get; set; }
        public decimal? Tablerownum { get; set; }
        public decimal Fieldsetid { get; set; }
        public string Statregid { get; set; }
        public string Statid { get; set; }
        public string Statnum { get; set; }
        public DateTime? Statdate { get; set; }
        public string ClName { get; set; }
        public string ClAddr { get; set; }
        public string ClMan { get; set; }
        public string ClGlbuh { get; set; }
        public string Typeoper { get; set; }
        public DateTime? ExchCurrdate { get; set; }
        public string ExchCurrrate { get; set; }
        public string ExchTypeoper { get; set; }
        public string ExchCurrcode { get; set; }
        public decimal? ExchCurrsumfig { get; set; }
        public string ExchCurrsumword { get; set; }
        public string ExchCurraccount { get; set; }
        public string ExchAccountrur { get; set; }
        public DateTime? RmtCurrdateremittance { get; set; }
        public string RmtAccounttransf { get; set; }
        public decimal? RmtSumremittance { get; set; }
        public string RmtCurrcode { get; set; }
        public string RcBankBic { get; set; }
        public string RcBankCorrespacc { get; set; }
        public string RcBankNamebank { get; set; }
        public string RcBankSwift { get; set; }
        public string RcBankAddrbank { get; set; }
        public string RcAccount { get; set; }
        public string RcNameprrcpnt { get; set; }
        public string RcInn { get; set; }
        public string RcKpp { get; set; }
        public string RcAddr { get; set; }
        public string CbBic { get; set; }
        public string CbCorrespacc { get; set; }
        public string CbNamebank { get; set; }
        public string CbSwift { get; set; }
        public string CbAddrbank { get; set; }
        public string CboBic { get; set; }
        public string CboCorrespacc { get; set; }
        public string CboNamebank { get; set; }
        public string CboSwift { get; set; }
        public string CboAddrbank { get; set; }
        public string CbtwBic { get; set; }
        public string CbtwCorrespacc { get; set; }
        public string CbtwNamebank { get; set; }
        public string CbtwSwift { get; set; }
        public string CbtwAddrbank { get; set; }
        public string CbthBic { get; set; }
        public string CbthCorrespacc { get; set; }
        public string CbthNamebank { get; set; }
        public string CbthSwift { get; set; }
        public string CbthAddrbank { get; set; }
        public string RmtPurpose { get; set; }
        public string RmtCommcost { get; set; }

        public virtual DcFamInfodtctnbDoc Doc { get; set; }
    }
}
