using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class DictionsAi
    {
        public decimal? DictId { get; set; }
        public decimal? CodeNum { get; set; }
        public string CodeStr { get; set; }
        public string Name { get; set; }
        public string DictionaryCode { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string LastUpdatedBy { get; set; }
        public DateTime? LastUpdatedDate { get; set; }
        public DateTime? StartDateActive { get; set; }
        public DateTime? EndDateActive { get; set; }
        public Guid? Uuid { get; set; }
        public Guid? HdrUuid { get; set; }
    }
}
