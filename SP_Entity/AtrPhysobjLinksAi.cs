using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class AtrPhysobjLinksAi
    {
        public decimal AtrPhysobjId { get; set; }
        public decimal? AtrId { get; set; }
        public decimal? PhysobjId { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string LastUpdatedBy { get; set; }
        public DateTime? LastUpdatedDate { get; set; }
        public string AtrDeveloperKey { get; set; }
        public string AtrPhysLinkType { get; set; }
        public string ConstvalueAtr { get; set; }
        public Guid? AtrPhysobjUuid { get; set; }
        public Guid? AtrUuid { get; set; }
        public Guid? PhysobjUuid { get; set; }

        public virtual AttributeAi Atr { get; set; }
        public virtual PhysobjAi Physobj { get; set; }
    }
}
