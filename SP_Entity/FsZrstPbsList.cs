using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class FsZrstPbsList
    {
        public decimal Fieldsetid { get; set; }
        public decimal? Tablerownum { get; set; }
        public decimal? Docid { get; set; }
        public string Fundssource { get; set; }
        public string KbkpKbk { get; set; }
        public string KbkpTargetcode { get; set; }
        public string KbkpBktype { get; set; }
        public string KbkrKbk { get; set; }
        public string KbkrTargetcode { get; set; }
        public string KbkrBktype { get; set; }
        public decimal? Amountcurrproposal { get; set; }
        public decimal? Amountrub { get; set; }
        public string Paypurpose { get; set; }
        public string Note { get; set; }
        public decimal? Numpp { get; set; }
        public string Namemode { get; set; }
        public string KbkpGrbscode { get; set; }
        public string KbkpSection { get; set; }
        public string KbkpSubsection { get; set; }
        public string KbkpTarget { get; set; }
        public string KbkpExp { get; set; }
        public string KbkpTargetname { get; set; }
        public string KbkrGrbscode { get; set; }
        public string KbkrSection { get; set; }
        public string KbkrSubsection { get; set; }
        public string KbkrTarget { get; set; }
        public string KbkrExp { get; set; }
        public string KbkrTargetname { get; set; }
        public string KbkpFkr { get; set; }
        public string KbkrFkr { get; set; }
        public string KbkrSubsidy { get; set; }

        public virtual DcMscApplcashflowPbs Doc { get; set; }
    }
}
