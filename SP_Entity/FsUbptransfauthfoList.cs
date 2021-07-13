using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class FsUbptransfauthfoList
    {
        public decimal Fieldsetid { get; set; }
        public decimal? Tablerownum { get; set; }
        public decimal? Docid { get; set; }
        public string Authfovillagesname { get; set; }
        public string Authfomunicipalname { get; set; }
        public string Authregnum { get; set; }
        public DateTime? Authstartdate { get; set; }
        public DateTime? Authenddate { get; set; }
        public string Orgnum { get; set; }
        public string Authpponame { get; set; }
        public string Authfovillagescode { get; set; }
        public string Authfomunicipalcode { get; set; }
        public string Budgetcode { get; set; }
        public string Glavacode { get; set; }
        public string Authppocode { get; set; }

        public virtual DcRefUbpandnubp Doc { get; set; }
    }
}
