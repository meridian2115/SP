using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class FsContentrnpD05List
    {
        public decimal? Docid { get; set; }
        public decimal? Tablerownum { get; set; }
        public decimal Fieldsetid { get; set; }
        public string LineNum { get; set; }
        public string Paymentguid { get; set; }
        public string Accdocnum { get; set; }
        public DateTime? Accdocdate { get; set; }
        public string PName { get; set; }
        public string PCheckacc { get; set; }
        public string PBankname { get; set; }
        public string PBik { get; set; }
        public string RName { get; set; }
        public string RInn { get; set; }
        public string RKpp { get; set; }
        public string RCheckacc { get; set; }
        public string RBankname { get; set; }
        public string RBik { get; set; }
        public string RCorracc { get; set; }
        public decimal? Paysum { get; set; }
        public string Paypurpose { get; set; }
        public string Tocancel { get; set; }

        public virtual DcFamRegofpaymentsD05 Doc { get; set; }
    }
}
