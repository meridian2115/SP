using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class AttributeAi
    {
        public AttributeAi()
        {
            AtrPhysobjLinksAi = new HashSet<AtrPhysobjLinksAi>();
            JoinrefAi = new HashSet<JoinrefAi>();
        }

        public decimal AtrId { get; set; }
        public decimal ObjId { get; set; }
        public decimal? PhysobjId { get; set; }
        public string AtrType { get; set; }
        public string AtrDatatype { get; set; }
        public string AtrName { get; set; }
        public decimal? AtrHidden { get; set; }
        public string AtrDeveloperKey { get; set; }
        public string Alignment { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string LastUpdatedBy { get; set; }
        public DateTime? LastUpdatedDate { get; set; }
        public string AtrProp1 { get; set; }
        public string AtrProp2 { get; set; }
        public decimal? AtrSectionId { get; set; }
        public decimal? AtrSequence { get; set; }
        public string AtrShortName { get; set; }
        public Guid? AtrUuid { get; set; }
        public Guid? ObjUuid { get; set; }

        public virtual AtrSectionAi AtrSection { get; set; }
        public virtual ObjAi Obj { get; set; }
        public virtual ICollection<AtrPhysobjLinksAi> AtrPhysobjLinksAi { get; set; }
        public virtual ICollection<JoinrefAi> JoinrefAi { get; set; }
    }
}
