using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class ObjAi
    {
        public ObjAi()
        {
            AtrSectionAi = new HashSet<AtrSectionAi>();
            AttributeAi = new HashSet<AttributeAi>();
            GlobalconditionAi = new HashSet<GlobalconditionAi>();
            InverseObjParent = new HashSet<ObjAi>();
            PhysobjAi = new HashSet<PhysobjAi>();
        }

        public decimal ObjId { get; set; }
        public decimal? ObjParentId { get; set; }
        public string ObjType { get; set; }
        public string ObjName { get; set; }
        public string ObjShortName { get; set; }
        public string ObjDescription { get; set; }
        public string ObjDeveloperKey { get; set; }
        public decimal? ObjHidden { get; set; }
        public string ObjProp1 { get; set; }
        public string ObjProp2 { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string LastUpdatedBy { get; set; }
        public DateTime? LastUpdatedDate { get; set; }
        public DateTime? StartDateActive { get; set; }
        public DateTime? EndDateActive { get; set; }
        public string ObjProp3 { get; set; }
        public string ObjProp4 { get; set; }
        public Guid? RobjUuid { get; set; }
        public Guid? ObjUuid { get; set; }
        public Guid? ObjParentUuid { get; set; }

        public virtual ObjAi ObjParent { get; set; }
        public virtual ICollection<AtrSectionAi> AtrSectionAi { get; set; }
        public virtual ICollection<AttributeAi> AttributeAi { get; set; }
        public virtual ICollection<GlobalconditionAi> GlobalconditionAi { get; set; }
        public virtual ICollection<ObjAi> InverseObjParent { get; set; }
        public virtual ICollection<PhysobjAi> PhysobjAi { get; set; }
    }
}
