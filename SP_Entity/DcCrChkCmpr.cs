using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class DcCrChkCmpr
    {
        public DcCrChkCmpr()
        {
            FsCcleftList = new HashSet<FsCcleftList>();
            FsCcrightList = new HashSet<FsCcrightList>();
        }

        public decimal Docid { get; set; }
        public decimal? Version { get; set; }

        public virtual ICollection<FsCcleftList> FsCcleftList { get; set; }
        public virtual ICollection<FsCcrightList> FsCcrightList { get; set; }
    }
}
