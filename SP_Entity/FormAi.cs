using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class FormAi
    {
        public FormAi()
        {
            FormBlockAi = new HashSet<FormBlockAi>();
        }

        public decimal FormId { get; set; }
        public string FormName { get; set; }
        public string FormCode { get; set; }
        public decimal? IsActual { get; set; }
        public DateTime? StartDateActive { get; set; }
        public DateTime? EndDateActive { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? LastUpdatedDate { get; set; }
        public decimal? BaId { get; set; }
        public string LastUpdatedBy { get; set; }
        public string CreatedBy { get; set; }
        public Guid? FormUuid { get; set; }
        public Guid? BaUuid { get; set; }

        public virtual BasAi Ba { get; set; }
        public virtual ICollection<FormBlockAi> FormBlockAi { get; set; }
    }
}
