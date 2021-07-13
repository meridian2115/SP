using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class PhysobjDatasetAi
    {
        public PhysobjDatasetAi()
        {
            PhysobjAi = new HashSet<PhysobjAi>();
        }

        public Guid DatasetUuid { get; set; }
        public decimal DatasetId { get; set; }
        public string DatasetName { get; set; }
        public decimal? DatasetNum { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string LastUpdatedBy { get; set; }
        public DateTime? LastUpdatedDate { get; set; }

        public virtual ICollection<PhysobjAi> PhysobjAi { get; set; }
    }
}
