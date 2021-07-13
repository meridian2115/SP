using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class DcSetsOfReporting
    {
        public DcSetsOfReporting()
        {
            FsRepFormsList = new HashSet<FsRepFormsList>();
        }

        public decimal Docid { get; set; }
        public decimal? Version { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public string TypeRepPeriod { get; set; }
        public string TsrTypeSubjRep { get; set; }
        public string Note { get; set; }
        public DateTime? DataStartactive { get; set; }
        public DateTime? DataEndactive { get; set; }
        public string BtCodeOfBudget { get; set; }
        public string BtNameOfBudget { get; set; }
        public string BtCodeOfType { get; set; }
        public string GlavaBk { get; set; }
        public string Prd { get; set; }
        public bool? Notification { get; set; }
        public bool? FlagNotification { get; set; }

        public virtual ICollection<FsRepFormsList> FsRepFormsList { get; set; }
    }
}
