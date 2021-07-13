using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class DocTagAssociation
    {
        public decimal Id { get; set; }
        public decimal? Tagid { get; set; }
        public decimal? Docid { get; set; }
        public DateTime? Created { get; set; }
        public decimal? Version { get; set; }
    }
}
