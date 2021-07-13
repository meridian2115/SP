using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class Userinfo
    {
        public Userinfo()
        {
            AutosaveData = new HashSet<AutosaveData>();
            DocTag = new HashSet<DocTag>();
            UserTagFolder = new HashSet<UserTagFolder>();
        }

        public decimal Userinfoid { get; set; }
        public decimal? Version { get; set; }
        public string Systemname { get; set; }
        public string Name { get; set; }
        public string Locale { get; set; }
        public bool? Locked { get; set; }
        public decimal? Userprofileid { get; set; }
        public byte[] Passwordhash { get; set; }
        public byte[] Salt { get; set; }
        public decimal? Userrequisitesid { get; set; }
        public bool? Mustchangepassword { get; set; }
        public decimal? Officeid { get; set; }
        public bool? Certauthorization { get; set; }
        public string Email { get; set; }
        public string Externalsystemid { get; set; }
        public string Title { get; set; }
        public string Department { get; set; }
        public string Samaccountname { get; set; }
        public string Accountguid { get; set; }

        public virtual ICollection<AutosaveData> AutosaveData { get; set; }
        public virtual ICollection<DocTag> DocTag { get; set; }
        public virtual ICollection<UserTagFolder> UserTagFolder { get; set; }
    }
}
