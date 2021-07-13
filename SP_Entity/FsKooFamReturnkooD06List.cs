using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class FsKooFamReturnkooD06List
    {
        public decimal? Docid { get; set; }
        public decimal? Tablerownum { get; set; }
        public decimal Fieldsetid { get; set; }
        public string Numpp { get; set; }
        public string Numkoo { get; set; }
        public DateTime? Datekoo { get; set; }
        public string Tofkcodestateclient { get; set; }
        public string PInn { get; set; }
        public string PKpp { get; set; }
        public string PPersonalacc { get; set; }
        public string PName { get; set; }
        public string PCheckacc { get; set; }
        public string PBik { get; set; }
        public string PBankname { get; set; }
        public string PCorracc { get; set; }
        public string RInn { get; set; }
        public string RKpp { get; set; }
        public string RName { get; set; }
        public string RCheckacc { get; set; }
        public string RBik { get; set; }
        public string RBankname { get; set; }
        public string RCorracc { get; set; }
        public string Paypurpose { get; set; }
        public string Guidkoo { get; set; }
        public string Analyticcodepay { get; set; }
        public string Analyticcoderec { get; set; }
        public decimal? Sumkbk { get; set; }
        public string Codfaip { get; set; }
        public string Guidd33 { get; set; }

        public virtual DcFamPaymorderdbD06 Doc { get; set; }
    }
}
