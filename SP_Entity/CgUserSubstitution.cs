using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class CgUserSubstitution
    {
        public decimal Id { get; set; }
        public decimal SubstedUserinfoId { get; set; }
        public decimal SubstingUserinfoId { get; set; }
        public string SubstedSubjectCn { get; set; }
        public string SubstedSubjectOrg { get; set; }
        public string SubstedSubjectTitle { get; set; }
        public string SubstingSubjectCn { get; set; }
        public string SubstingSubjectOrg { get; set; }
        public string SubstingSubjectTitle { get; set; }
        public DateTime StartValidDate { get; set; }
        public DateTime EndValidDate { get; set; }
        public DateTime? NullificationDate { get; set; }
        public byte[] NullificationCmsSign { get; set; }
        public decimal IsPassable { get; set; }
        public decimal? PrevUserSubstitId { get; set; }
        public string Description { get; set; }
        public byte[] NullificationUhashData { get; set; }
        public string SubstedUserinfoName { get; set; }
        public string SubstingUserinfoName { get; set; }
    }
}
