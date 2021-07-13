using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class FsStrvippdinvD24List
    {
        public decimal Fieldsetid { get; set; }
        public decimal? Tablerownum { get; set; }
        public decimal? Docid { get; set; }
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
        public decimal? Accountrate { get; set; }
        public DateTime? Valuedate { get; set; }
        public string Transtype { get; set; }
        public string EdtEdno { get; set; }
        public string EdtEdauthor { get; set; }
        public DateTime? EdtEddate { get; set; }
        public string EdtOpcode { get; set; }
        public string PdrDoctype { get; set; }
        public string PdrEdno { get; set; }
        public DateTime? PdrEddate { get; set; }
        public string PdrEpdauthor { get; set; }
        public string PdrDocnum { get; set; }
        public DateTime? PdrDocdate { get; set; }
        public string InvSlipno { get; set; }
        public DateTime? InvSlipdate { get; set; }
        public string InvAccnumcus { get; set; }
        public string InvAccnumbenf { get; set; }
        public decimal? InvSumfinal { get; set; }
        public DateTime? InvValuedate { get; set; }
        public string InvRatetype { get; set; }
        public decimal? InvSettlementrate { get; set; }
        public string SwfOrderingcustomer { get; set; }
        public string SwfOrderingbeneficiary { get; set; }
        public string SwfInstinfo { get; set; }
        public string SwfRemittanceinfo { get; set; }
        public string SwfSendertoreceiverinfo { get; set; }
        public string PNostro { get; set; }
        public string PSwiftcode { get; set; }
        public string PCurrcodebought { get; set; }
        public decimal? PSumbought { get; set; }
        public decimal? PSumincurr { get; set; }
        public string RSwiftcode { get; set; }
        public string RNostro { get; set; }
        public string RCurrcodesold { get; set; }
        public DateTime? RValuedate { get; set; }
        public decimal? RSumsold { get; set; }
        public decimal? RSumincurr { get; set; }
        public string PCorrespacc { get; set; }
        public string RCorrespacc { get; set; }
        public string Acccorr { get; set; }
        public decimal? Kol { get; set; }

        public virtual DcFamExtractperaccD24 Doc { get; set; }
    }
}
