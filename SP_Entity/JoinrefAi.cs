using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class JoinrefAi
    {
        public decimal JoinrefId { get; set; }
        public decimal? AtrId { get; set; }
        public decimal? JoinId { get; set; }
        public string JoinrefType { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string LastUpdatedBy { get; set; }
        public DateTime? LastUpdatedDate { get; set; }
        public Guid? JoinrefUuid { get; set; }
        public Guid? AtrUuid { get; set; }
        public Guid? JoinUuid { get; set; }

        public virtual AttributeAi Atr { get; set; }
        public virtual JoinAi Join { get; set; }
    }
}
