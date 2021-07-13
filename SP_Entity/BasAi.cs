using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class BasAi
    {
        public BasAi()
        {
            DictionsHeaderAi = new HashSet<DictionsHeaderAi>();
            FormAi = new HashSet<FormAi>();
            GlSubstVarAi = new HashSet<GlSubstVarAi>();
            SearchFormAi = new HashSet<SearchFormAi>();
            UserFormSettingsAi = new HashSet<UserFormSettingsAi>();
        }

        public decimal BaId { get; set; }
        public string BaName { get; set; }
        public decimal? IsActual { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string LastUpdatedBy { get; set; }
        public DateTime? LastUpdatedDate { get; set; }
        public string BaDeveloperKey { get; set; }
        public Guid? BaUuid { get; set; }

        public virtual ICollection<DictionsHeaderAi> DictionsHeaderAi { get; set; }
        public virtual ICollection<FormAi> FormAi { get; set; }
        public virtual ICollection<GlSubstVarAi> GlSubstVarAi { get; set; }
        public virtual ICollection<SearchFormAi> SearchFormAi { get; set; }
        public virtual ICollection<UserFormSettingsAi> UserFormSettingsAi { get; set; }
    }
}
