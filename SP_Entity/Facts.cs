using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class Facts
    {
        public Facts()
        {
            FactParams = new HashSet<FactParams>();
        }

        public decimal Id { get; set; }
        public string Orgcode { get; set; }
        public string Userid { get; set; }
        public string Facttype { get; set; }
        public DateTime Created { get; set; }
        public string Doctype { get; set; }
        public string Docguid { get; set; }
        public string Docnum { get; set; }
        public DateTime? Docdate { get; set; }
        public decimal Amount { get; set; }
        public string Adddoctype { get; set; }
        public string Subsystem { get; set; }

        public virtual ICollection<FactParams> FactParams { get; set; }
    }
}
