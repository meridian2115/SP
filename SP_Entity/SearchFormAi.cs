using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class SearchFormAi
    {
        public decimal SearchFormId { get; set; }
        public decimal BaId { get; set; }
        public byte[] SettingsForm { get; set; }
        public DateTime? StartDateActive { get; set; }
        public DateTime? EndDateActive { get; set; }
        public decimal? IsActual { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string LastUpdatedBy { get; set; }
        public DateTime? LastUpdatedDate { get; set; }
        public Guid? SearchFormUuid { get; set; }
        public Guid? BaUuid { get; set; }

        public virtual BasAi Ba { get; set; }
    }
}
