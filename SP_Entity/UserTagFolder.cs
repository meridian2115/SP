using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class UserTagFolder
    {
        public decimal Id { get; set; }
        public decimal? Version { get; set; }
        public string Name { get; set; }
        public decimal? Userid { get; set; }
        public decimal? Doctagid { get; set; }
        public decimal? Previousnodeid { get; set; }
        public DateTime? Created { get; set; }

        public virtual DocTag Doctag { get; set; }
        public virtual Userinfo User { get; set; }
    }
}
