using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class FsUbpnubpauthsList
    {
        public decimal Fieldsetid { get; set; }
        public decimal? Tablerownum { get; set; }
        public decimal? Docid { get; set; }
        public string Authname { get; set; }
        public DateTime? Authstartdate { get; set; }
        public DateTime? Authenddate { get; set; }
        public string Authbudgname { get; set; }
        public string Authpponame { get; set; }
        public string Authkbkglavaname { get; set; }
        public string Authregnum { get; set; }
        public string Authstatus { get; set; }
        public string Authbudglevelname { get; set; }
        public string Nameuo { get; set; }
        public string Authorgname { get; set; }
        public string Authcode { get; set; }
        public string Authbudgcode { get; set; }
        public string Authppocode { get; set; }
        public string Authkbkglavacode { get; set; }
        public string Authorgcode { get; set; }
        public string Authbudglevelcode { get; set; }
        public string Orgcodeuo { get; set; }

        public virtual DcRefUbpandnubp Doc { get; set; }
    }
}
