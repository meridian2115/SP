using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class FsDictcommonfields
    {
        public decimal Dictid { get; set; }
        public DateTime? Docdate { get; set; }
        public string Docnumber { get; set; }
        public decimal? Docsum { get; set; }
        public string Docsumcurrency { get; set; }
        public DateTime? Acceptdate { get; set; }
        public DateTime? Valuedate { get; set; }
        public string Docaccount { get; set; }
        public string Dcomment { get; set; }
        public string Sender { get; set; }
        public string Recipient { get; set; }
        public string Budgetcode { get; set; }
        public string Budgetname { get; set; }
        public string Bscode { get; set; }
        public string Bsname { get; set; }
        public string Prevbusinessstatecode { get; set; }
        public string Doctypecode { get; set; }
        public string Docanswer { get; set; }
        public string Tffversion { get; set; }
        public string Currentlevel { get; set; }
        public DateTime? Tradingday { get; set; }
        public string Docguid { get; set; }
        public string Parentdocguid { get; set; }
        public string Parentdoctype { get; set; }
        public decimal? Doctypeid { get; set; }
        public decimal? Docstateid { get; set; }
        public decimal Deleted { get; set; }

        public virtual Dict Dict { get; set; }
    }
}
