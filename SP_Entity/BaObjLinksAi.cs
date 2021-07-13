using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class BaObjLinksAi
    {
        public decimal BaId { get; set; }
        public Guid RobjUuid { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string LastUpdatedBy { get; set; }
        public DateTime? LastUpdatedDate { get; set; }
        public Guid? BaUuid { get; set; }

        public virtual BasAi Ba { get; set; }
        public virtual RobjAi RobjUu { get; set; }
    }
}
