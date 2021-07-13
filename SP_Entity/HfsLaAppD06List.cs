using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class HfsLaAppD06List
    {
        public decimal Fieldsetid { get; set; }
        public decimal? Tablerownum { get; set; }
        public decimal? Id { get; set; }
        public DateTime? ApproverStartdate { get; set; }
        public string ApproverNote { get; set; }
        public DateTime? ApproverDate { get; set; }

        public virtual HFamPaymorderdbD06 IdNavigation { get; set; }
    }
}
