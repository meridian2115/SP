using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class HFamPaymorderdbD06
    {
        public HFamPaymorderdbD06()
        {
            HfsLaAgrD06List = new HashSet<HfsLaAgrD06List>();
            HfsLaAppD06List = new HashSet<HfsLaAppD06List>();
            HfsLaExecD06List = new HashSet<HfsLaExecD06List>();
        }

        public decimal Id { get; set; }

        public virtual ICollection<HfsLaAgrD06List> HfsLaAgrD06List { get; set; }
        public virtual ICollection<HfsLaAppD06List> HfsLaAppD06List { get; set; }
        public virtual ICollection<HfsLaExecD06List> HfsLaExecD06List { get; set; }
    }
}
