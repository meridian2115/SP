using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class DcRefPeracc
    {
        public decimal Docid { get; set; }
        public decimal? Version { get; set; }
        public string Accnum { get; set; }
        public string Acctype { get; set; }
        public string OwnaccCodeownacc { get; set; }
        public string OwnaccNameownacc { get; set; }
        public string Legalname { get; set; }
        public string Legaladdress { get; set; }
        public string Indtxpridntnm { get; set; }
        public string Cdrsnrg { get; set; }
        public string CeobudgetCodeceo { get; set; }
        public string CeobudgetNameceo { get; set; }
        public string BudgetCodebudget { get; set; }
        public string BudgetNamebudget { get; set; }
        public string FedtrCodefedtr { get; set; }
        public string FedtrNamefedtr { get; set; }
        public string AccfedtrCuraccfedtr { get; set; }
        public string Codefinauth { get; set; }
        public string Namefinauth { get; set; }
        public string PeraccAccbudfinaut { get; set; }
        public string Note { get; set; }
        public DateTime? DataStartactive { get; set; }
        public DateTime? DataEndactive { get; set; }
        public string Cdbu { get; set; }
        public string Guidnsi { get; set; }
        public string Vbuvrpp { get; set; }
        public string Guid { get; set; }
    }
}
