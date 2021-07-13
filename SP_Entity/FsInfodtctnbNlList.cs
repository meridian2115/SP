using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class FsInfodtctnbNlList
    {
        public decimal? Docid { get; set; }
        public decimal? Tablerownum { get; set; }
        public decimal Fieldsetid { get; set; }
        public string Notifregid { get; set; }
        public string Notifid { get; set; }
        public string Notifnum { get; set; }
        public DateTime? Notifdate { get; set; }
        public string BnName { get; set; }
        public string BnAccount { get; set; }
        public string BnNamebank { get; set; }
        public string BnBic { get; set; }
        public string CurrCode { get; set; }
        public decimal? CurrSum { get; set; }
        public decimal? CurrSumrur { get; set; }
        public DateTime? CurrCrdate { get; set; }
        public string CstCode { get; set; }
        public string CstInn { get; set; }
        public string CstName { get; set; }
        public string InfoTransf { get; set; }
        public string InfoBanktransf { get; set; }
        public string InfoBenfc { get; set; }
        public string InfoRecip { get; set; }
        public string InfoPay { get; set; }
        public string BnCorraccount { get; set; }

        public virtual DcFamInfodtctnbDoc Doc { get; set; }
    }
}
