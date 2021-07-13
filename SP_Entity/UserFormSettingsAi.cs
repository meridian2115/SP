﻿using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class UserFormSettingsAi
    {
        public decimal UserFormSettingsId { get; set; }
        public decimal? BaId { get; set; }
        public string FormCode { get; set; }
        public string UserLogin { get; set; }
        public decimal? VersionId { get; set; }
        public byte[] SettingsForm { get; set; }
        public decimal? IsActual { get; set; }
        public DateTime? StartDateActive { get; set; }
        public DateTime? EndDateActive { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? LastUpdatedDate { get; set; }
        public Guid? UserFormSettingsUuid { get; set; }
        public Guid? BaUuid { get; set; }

        public virtual BasAi Ba { get; set; }
    }
}
