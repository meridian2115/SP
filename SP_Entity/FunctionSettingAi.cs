using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class FunctionSettingAi
    {
        public Guid FunctionSettingUuid { get; set; }
        public string FunctionName { get; set; }
        public string FunctionSetting { get; set; }
        public string FunctionSettingDescr { get; set; }
        public bool? EnabledFlag { get; set; }
        public DateTime? StartDateActive { get; set; }
        public DateTime? EndDateActive { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreationDate { get; set; }
        public string LastUpdatedBy { get; set; }
        public DateTime? LastUpdateDate { get; set; }
        public bool? IsDeleted { get; set; }
        public short? FunctionType { get; set; }
    }
}
