using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class DcRatiosControl
    {
        public DcRatiosControl()
        {
            FsIndexesList = new HashSet<FsIndexesList>();
        }

        public decimal Docid { get; set; }
        public decimal? Version { get; set; }
        public string RatioCode { get; set; }
        public string TypeOfControl { get; set; }
        public string TypeOfPeriod { get; set; }
        public string Content { get; set; }
        public string Comparison { get; set; }
        public string ErrorMessageText { get; set; }
        public DateTime? DataStartactive { get; set; }
        public DateTime? DataEndactive { get; set; }

        public virtual ICollection<FsIndexesList> FsIndexesList { get; set; }
    }
}
