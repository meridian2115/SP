using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class GlSubstVarAi
    {
        public decimal SubstvarId { get; set; }
        public string SubstVar { get; set; }
        public string FormComp { get; set; }
        public string SvarDatatype { get; set; }
        public string DescrSubstVar { get; set; }
        public decimal? BaId { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string LastUpdateBy { get; set; }
        public DateTime? LastUpdateDate { get; set; }
        public Guid? SubstvarUuid { get; set; }
        public Guid? BaUuid { get; set; }

        public virtual BasAi Ba { get; set; }
    }
}
