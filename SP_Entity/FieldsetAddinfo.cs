using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class FieldsetAddinfo
    {
        public decimal Fieldsetid { get; set; }
        public string Budgetcode { get; set; }
        public string Doctypecode { get; set; }
        public decimal? Securitymode { get; set; }
        public string Businessstatecode { get; set; }
        public string Businessstatename { get; set; }
        public string Docanswer { get; set; }
        public string Parentdocnumber { get; set; }
        public DateTime? Parentdocdate { get; set; }
        public string Budgetname { get; set; }
        public string Doctypename { get; set; }
        public string Securitymodename { get; set; }
        public DateTime? Fd { get; set; }
        public DateTime? Td { get; set; }
        public string Docregnumber { get; set; }
        public DateTime? Docregdate { get; set; }
        public DateTime? Docinputdate { get; set; }
        public DateTime? Docrecivedate { get; set; }
        public decimal? Transit { get; set; }
        public bool? Ismultisend { get; set; }
        public string Docnumber { get; set; }
        public string Currentlevel { get; set; }
        public string Highertofk { get; set; }
        public string Segmentcode { get; set; }
        public string Doctofkcode { get; set; }
        public string Contour { get; set; }
        public string Docguid { get; set; }
        public string Parentdocguid { get; set; }
        public string Docaccount { get; set; }
        public DateTime? Tradingday { get; set; }
        public string Syncaccount { get; set; }
        public bool? Protokol { get; set; }
    }
}
