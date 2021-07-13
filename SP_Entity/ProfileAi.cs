using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class ProfileAi
    {
        public decimal ProfileId { get; set; }
        public decimal UserId { get; set; }
        public string UserLogin { get; set; }
        public string ProfileName { get; set; }
        public byte[] Profilexml { get; set; }
        public string EnabledFlag { get; set; }
        public decimal? Version { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreationDate { get; set; }
        public string LastUpdatedBy { get; set; }
        public DateTime? LastUpdateDate { get; set; }
        public string Orgcode { get; set; }
        public string Scope { get; set; }
        public decimal? ProfileVerId { get; set; }
        public Guid? ProfileUuid { get; set; }
        public Guid? ProfileVerUuid { get; set; }

        public virtual ProfileVerificationTmplAi ProfileVer { get; set; }
    }
}
