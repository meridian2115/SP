using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class AtrSectionAi
    {
        public AtrSectionAi()
        {
            AttributeAi = new HashSet<AttributeAi>();
        }

        public decimal AtrSectionId { get; set; }
        public decimal ObjId { get; set; }
        public string AtrSectionName { get; set; }
        public decimal? AtrSequence { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string LastUpdatedBy { get; set; }
        public DateTime? LastUpdatedDate { get; set; }
        public Guid? AtrSectionUuid { get; set; }
        public Guid? ObjUuid { get; set; }

        public virtual ObjAi Obj { get; set; }
        public virtual ICollection<AttributeAi> AttributeAi { get; set; }
    }
}
