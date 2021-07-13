using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class FsStrvippdD24List
    {
        public decimal? Docid { get; set; }
        public decimal? Tablerownum { get; set; }
        public decimal Fieldsetid { get; set; }
        public string Epdno { get; set; }
        public DateTime? Epddate { get; set; }
        public string Epdauthor { get; set; }
        public string Paypurpose { get; set; }
        public string Paypriority { get; set; }
        public string Typeoper { get; set; }
        public string Typeobor { get; set; }
        public string Dbcr { get; set; }
        public string Edno { get; set; }
        public DateTime? Eddate { get; set; }
        public decimal? Sumeps { get; set; }
        public string PInnpayer { get; set; }
        public string PKpppayer { get; set; }
        public string PBik { get; set; }
        public string PAccpayer { get; set; }
        public string PBankname { get; set; }
        public string PName { get; set; }
        public string RInn { get; set; }
        public string RKpp { get; set; }
        public string RBankname { get; set; }
        public string RBik { get; set; }
        public string RAccrecipient { get; set; }
        public string RName { get; set; }
        public string Guidepd { get; set; }
        public string Signkvit { get; set; }
        public string Prkvit { get; set; }
        public string Statusbank { get; set; }
        public string Statusbyextract { get; set; }
        public string PCurrcodebought { get; set; }
        public string RCurrcodesold { get; set; }
        public string Transtype { get; set; }
        public string Acccorr { get; set; }
        public decimal? Kol { get; set; }

        public virtual DcFamExtractperaccD24 Doc { get; set; }
    }
}
