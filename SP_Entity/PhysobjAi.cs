using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class PhysobjAi
    {
        public PhysobjAi()
        {
            AtrPhysobjLinksAi = new HashSet<AtrPhysobjLinksAi>();
        }

        public decimal PhysobjId { get; set; }
        public decimal? ObjId { get; set; }
        public string PhysobjType { get; set; }
        public string PhysobjName { get; set; }
        public string PhysobjOwner { get; set; }
        public string PhysobjExtTable { get; set; }
        public string PhysobjSql1 { get; set; }
        public string PhysobjSql2 { get; set; }
        public string PhysobjSql3 { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string LastUpdatedBy { get; set; }
        public DateTime? LastUpdatedDate { get; set; }
        public decimal? PhysobjDatasetNum { get; set; }
        public decimal? DatasetId { get; set; }
        public Guid? PhysobjUuid { get; set; }
        public Guid? ObjUuid { get; set; }
        public Guid? DatasetUuid { get; set; }

        public virtual PhysobjDatasetAi Dataset { get; set; }
        public virtual ObjAi Obj { get; set; }
        public virtual ICollection<AtrPhysobjLinksAi> AtrPhysobjLinksAi { get; set; }
    }
}
