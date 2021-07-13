using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class DictDescrAiNew
    {
        public string DictionaryCode { get; set; }
        public string SqlStr { get; set; }
        public string DictionaryName { get; set; }
        public decimal? BaId { get; set; }
        public Guid? BaUuid { get; set; }
        public bool? IsHierarchy { get; set; }
        public string HierSqlStr { get; set; }
        public string NumOpz { get; set; }

        public virtual BasAi Ba { get; set; }
    }
}
