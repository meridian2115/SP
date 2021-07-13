using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class DcArpFahSets
    {
        public DcArpFahSets()
        {
            FsRegistresList = new HashSet<FsRegistresList>();
        }

        public decimal Docid { get; set; }
        public decimal? Version { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public string TsrTypeSubjRep { get; set; }
        public string Note { get; set; }
        public DateTime? DataStartactive { get; set; }
        public DateTime? DataEndactive { get; set; }
        public string Cscode { get; set; }
        public string TypePeriod { get; set; }
        public string ReportSet { get; set; }
        public string ReportSetn { get; set; }
        public string BudgetLevel { get; set; }
        public string BudgetLeveln { get; set; }
        public string TypePeriodTech { get; set; }

        public virtual ICollection<FsRegistresList> FsRegistresList { get; set; }
    }
}
