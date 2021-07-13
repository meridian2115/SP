using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class FsRegisterordersD13List
    {
        public decimal? Docid { get; set; }
        public decimal? Tablerownum { get; set; }
        public decimal Fieldsetid { get; set; }
        public string Transactionid { get; set; }
        public string Docguid { get; set; }
        public string Docnum { get; set; }
        public DateTime? Docdate { get; set; }
        public string Operationid { get; set; }
        public DateTime? Transactiondate { get; set; }
        public decimal? Transactionsum { get; set; }
        public string Paymentid { get; set; }
        public string Transactionpurpose { get; set; }
        public string Remittanceinfo { get; set; }
        public string PPersonalid { get; set; }
        public string PCheckacc { get; set; }
        public string PInn { get; set; }
        public string PName { get; set; }
        public string PAddress { get; set; }
        public string PTradename { get; set; }
        public string RPersonalid { get; set; }
        public string RCheckacc { get; set; }
        public string RInn { get; set; }
        public string RName { get; set; }
        public string RAddress { get; set; }
        public string RTradename { get; set; }
        public string BPersonalid { get; set; }
        public string BCheckacc { get; set; }
        public string BInn { get; set; }
        public string BName { get; set; }
        public string BAddress { get; set; }
        public string BTradename { get; set; }
        public string DfF101r { get; set; }
        public string DfF106r { get; set; }
        public string DfF107r { get; set; }
        public string DfF108r { get; set; }
        public string DfF109r { get; set; }
        public string DfF110r { get; set; }
        public string DfF111r { get; set; }
        public string DfF112r { get; set; }

        public virtual DcFamPaymorderwithregD13 Doc { get; set; }
    }
}
