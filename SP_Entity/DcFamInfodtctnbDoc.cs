using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class DcFamInfodtctnbDoc
    {
        public DcFamInfodtctnbDoc()
        {
            FsInfodtctnbDiFuncList = new HashSet<FsInfodtctnbDiFuncList>();
            FsInfodtctnbDiIncomList = new HashSet<FsInfodtctnbDiIncomList>();
            FsInfodtctnbDiInterList = new HashSet<FsInfodtctnbDiInterList>();
            FsInfodtctnbDiIntraList = new HashSet<FsInfodtctnbDiIntraList>();
            FsInfodtctnbDiList = new HashSet<FsInfodtctnbDiList>();
            FsInfodtctnbDidtFuncList = new HashSet<FsInfodtctnbDidtFuncList>();
            FsInfodtctnbDidtIncomList = new HashSet<FsInfodtctnbDidtIncomList>();
            FsInfodtctnbDidtInterList = new HashSet<FsInfodtctnbDidtInterList>();
            FsInfodtctnbDidtIntraList = new HashSet<FsInfodtctnbDidtIntraList>();
            FsInfodtctnbDidtList = new HashSet<FsInfodtctnbDidtList>();
            FsInfodtctnbDiktFuncList = new HashSet<FsInfodtctnbDiktFuncList>();
            FsInfodtctnbDiktIncomList = new HashSet<FsInfodtctnbDiktIncomList>();
            FsInfodtctnbDiktInterList = new HashSet<FsInfodtctnbDiktInterList>();
            FsInfodtctnbDiktIntraList = new HashSet<FsInfodtctnbDiktIntraList>();
            FsInfodtctnbDiktList = new HashSet<FsInfodtctnbDiktList>();
            FsInfodtctnbDiuFuncList = new HashSet<FsInfodtctnbDiuFuncList>();
            FsInfodtctnbDiuIncomList = new HashSet<FsInfodtctnbDiuIncomList>();
            FsInfodtctnbDiuInterList = new HashSet<FsInfodtctnbDiuInterList>();
            FsInfodtctnbDiuIntraList = new HashSet<FsInfodtctnbDiuIntraList>();
            FsInfodtctnbDiuList = new HashSet<FsInfodtctnbDiuList>();
            FsInfodtctnbNlList = new HashSet<FsInfodtctnbNlList>();
            FsInfodtctnbSlList = new HashSet<FsInfodtctnbSlList>();
        }

        public decimal Docid { get; set; }
        public decimal? Version { get; set; }
        public string Doctype { get; set; }
        public bool? Forcurr { get; set; }
        public DateTime? Creationdate { get; set; }
        public DateTime? Opdaydate { get; set; }
        public decimal? Docsum { get; set; }
        public decimal? Suminval { get; set; }
        public decimal? Currencyrate { get; set; }
        public string EsEdno { get; set; }
        public DateTime? EsEddate { get; set; }
        public string EsEdauthor { get; set; }
        public string EsEdreceiver { get; set; }
        public string AdNo { get; set; }
        public string AdAccount { get; set; }
        public DateTime? AdAddate { get; set; }
        public string PrBankBic { get; set; }
        public string PrBankCorrespacc { get; set; }
        public string PrBankNamebank { get; set; }
        public string PrBankSwift { get; set; }
        public string PrBankAddrbank { get; set; }
        public string PrAccount { get; set; }
        public string PrNameprrcpnt { get; set; }
        public string PrInn { get; set; }
        public string PrKpp { get; set; }
        public string PrAddr { get; set; }
        public string PeBankBic { get; set; }
        public string PeBankCorrespacc { get; set; }
        public string PeBankNamebank { get; set; }
        public string PeBankSwift { get; set; }
        public string PeBankAddrbank { get; set; }
        public string PeAccount { get; set; }
        public string PeNameprrcpnt { get; set; }
        public string PeInn { get; set; }
        public string PeKpp { get; set; }
        public string PeAddr { get; set; }
        public string Purpose { get; set; }
        public string PnPersonalaccnew { get; set; }
        public string PnInnnew { get; set; }
        public string PnKppnew { get; set; }
        public string PnOkatonew { get; set; }
        public string PnNamenew { get; set; }
        public string PnPurposenew { get; set; }
        public string AduEdnou { get; set; }
        public DateTime? AduEddateu { get; set; }
        public DateTime? AduOpdaydateu { get; set; }
        public decimal? AduSumu { get; set; }
        public decimal? AduSuminvalu { get; set; }
        public string AduAccdocnou { get; set; }
        public string AduPersonalpayeraccu { get; set; }
        public string AduPersonalpayeeaccu { get; set; }
        public string AduTaxperiod { get; set; }
        public DateTime? Dtload { get; set; }
        public string CurrCd { get; set; }
        public string CurrNm { get; set; }
        public string Docname { get; set; }
        public string Cbctype { get; set; }
        public string PrTofk { get; set; }
        public string PeTofk { get; set; }
        public string DoctypePdVnb { get; set; }
        public bool? Nl { get; set; }
        public bool? Sl { get; set; }
        public decimal? DocsumPrih { get; set; }
        public decimal? SuminvalPrih { get; set; }
        public decimal? DocsumRash { get; set; }
        public decimal? SuminvalRash { get; set; }
        public string Accountcorr { get; set; }
        public string Accountorfk { get; set; }
        public string Namecorr { get; set; }
        public string Nameorfk { get; set; }
        public string CbcRash1 { get; set; }
        public string CbcRash2 { get; set; }
        public string CbcRash3 { get; set; }
        public string CbcIst1 { get; set; }
        public string CbcIst2 { get; set; }
        public string CbcIst3 { get; set; }
        public string CbcDoh { get; set; }
        public string Prevstate { get; set; }
        public decimal? SumcbcvDoh { get; set; }
        public decimal? SumcbcrDoh { get; set; }
        public decimal? SumcbcrRash1 { get; set; }
        public decimal? SumcbcrRash2 { get; set; }
        public decimal? SumcbcrRash3 { get; set; }
        public decimal? SumcbcrIst1 { get; set; }
        public decimal? SumcbcrIst2 { get; set; }
        public decimal? SumcbcrIst3 { get; set; }
        public decimal? SumcbcvRash1 { get; set; }
        public decimal? SumcbcvRash2 { get; set; }
        public decimal? SumcbcvRash3 { get; set; }
        public decimal? SumcbcvIst1 { get; set; }
        public decimal? SumcbcvIst2 { get; set; }
        public decimal? SumcbcvIst3 { get; set; }
        public string GuidU { get; set; }

        public virtual ICollection<FsInfodtctnbDiFuncList> FsInfodtctnbDiFuncList { get; set; }
        public virtual ICollection<FsInfodtctnbDiIncomList> FsInfodtctnbDiIncomList { get; set; }
        public virtual ICollection<FsInfodtctnbDiInterList> FsInfodtctnbDiInterList { get; set; }
        public virtual ICollection<FsInfodtctnbDiIntraList> FsInfodtctnbDiIntraList { get; set; }
        public virtual ICollection<FsInfodtctnbDiList> FsInfodtctnbDiList { get; set; }
        public virtual ICollection<FsInfodtctnbDidtFuncList> FsInfodtctnbDidtFuncList { get; set; }
        public virtual ICollection<FsInfodtctnbDidtIncomList> FsInfodtctnbDidtIncomList { get; set; }
        public virtual ICollection<FsInfodtctnbDidtInterList> FsInfodtctnbDidtInterList { get; set; }
        public virtual ICollection<FsInfodtctnbDidtIntraList> FsInfodtctnbDidtIntraList { get; set; }
        public virtual ICollection<FsInfodtctnbDidtList> FsInfodtctnbDidtList { get; set; }
        public virtual ICollection<FsInfodtctnbDiktFuncList> FsInfodtctnbDiktFuncList { get; set; }
        public virtual ICollection<FsInfodtctnbDiktIncomList> FsInfodtctnbDiktIncomList { get; set; }
        public virtual ICollection<FsInfodtctnbDiktInterList> FsInfodtctnbDiktInterList { get; set; }
        public virtual ICollection<FsInfodtctnbDiktIntraList> FsInfodtctnbDiktIntraList { get; set; }
        public virtual ICollection<FsInfodtctnbDiktList> FsInfodtctnbDiktList { get; set; }
        public virtual ICollection<FsInfodtctnbDiuFuncList> FsInfodtctnbDiuFuncList { get; set; }
        public virtual ICollection<FsInfodtctnbDiuIncomList> FsInfodtctnbDiuIncomList { get; set; }
        public virtual ICollection<FsInfodtctnbDiuInterList> FsInfodtctnbDiuInterList { get; set; }
        public virtual ICollection<FsInfodtctnbDiuIntraList> FsInfodtctnbDiuIntraList { get; set; }
        public virtual ICollection<FsInfodtctnbDiuList> FsInfodtctnbDiuList { get; set; }
        public virtual ICollection<FsInfodtctnbNlList> FsInfodtctnbNlList { get; set; }
        public virtual ICollection<FsInfodtctnbSlList> FsInfodtctnbSlList { get; set; }
    }
}
