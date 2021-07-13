using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class RobjAi
    {
        public Guid RobjUuid { get; set; }
        public string RobjType { get; set; }
        public string RobjName { get; set; }
        public string RobjDescription { get; set; }
        public decimal? RobjHidden { get; set; }
        public string RobjProp1 { get; set; }
        public string RobjProp2 { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string LastUpdatedBy { get; set; }
        public DateTime? LastUpdatedDate { get; set; }
        public DateTime? StartDateActive { get; set; }
        public DateTime? EndDateActive { get; set; }
    }
}
