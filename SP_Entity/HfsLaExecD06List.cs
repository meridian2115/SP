using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class HfsLaExecD06List
    {
        public decimal Fieldsetid { get; set; }
        public decimal? Tablerownum { get; set; }
        public decimal? Id { get; set; }
        public string ExecutorNote { get; set; }
        public DateTime? ExecutorStartdate { get; set; }
        public DateTime? ExecutorDate { get; set; }

        public virtual HFamPaymorderdbD06 IdNavigation { get; set; }
    }
}
