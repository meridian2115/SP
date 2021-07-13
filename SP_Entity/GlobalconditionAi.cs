using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class GlobalconditionAi
    {
        public decimal GlobalcondId { get; set; }
        public string ObjCondition { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string LastUpdateBy { get; set; }
        public DateTime? LastUpdateDate { get; set; }
        public decimal? ObjId { get; set; }
        public Guid? GlobalcondUuid { get; set; }
        public Guid? ObjUuid { get; set; }

        public virtual ObjAi Obj { get; set; }
    }
}
