using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class FsUbptransfauthbpList
    {
        public decimal Fieldsetid { get; set; }
        public decimal? Tablerownum { get; set; }
        public decimal? Docid { get; set; }
        public string Authpponame { get; set; }
        public string Authbudgname { get; set; }
        public string Authkbkglavaname { get; set; }
        public string Authbudglevelname { get; set; }
        public string Authbudgetcode { get; set; }
        public string Authglavacode { get; set; }
        public string Authppocode { get; set; }
        public string Authbudglevelcode { get; set; }

        public virtual DcRefUbpandnubp Doc { get; set; }
    }
}
