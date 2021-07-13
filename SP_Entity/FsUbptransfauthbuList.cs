using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class FsUbptransfauthbuList
    {
        public decimal Fieldsetid { get; set; }
        public decimal? Tablerownum { get; set; }
        public decimal? Docid { get; set; }
        public string Authbuauthorgcode { get; set; }
        public string Authbuauthorgname { get; set; }
        public DateTime? Authbuauthstartdate { get; set; }
        public DateTime? Authbuauthenddate { get; set; }
        public string Authbuauthorgcodeper { get; set; }

        public virtual DcRefUbpandnubp Doc { get; set; }
    }
}
