using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class JoinAi
    {
        public JoinAi()
        {
            JoinrefAi = new HashSet<JoinrefAi>();
        }

        public decimal JoinId { get; set; }
        public string JoinDescription { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string LastUpdatedBy { get; set; }
        public DateTime? LastUpdatedDate { get; set; }
        public string JoinType { get; set; }
        public Guid? JoinUuid { get; set; }

        public virtual ICollection<JoinrefAi> JoinrefAi { get; set; }
    }
}
