using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class DcListOfOrgDistrDir
    {
        public decimal Docid { get; set; }
        public decimal? Version { get; set; }
        public string SystemNameDict { get; set; }
        public string BudgetCode { get; set; }
        public string ChiefAdminCode { get; set; }
        public string InstitutionCode { get; set; }
        public string InstitutionName { get; set; }
        public string OrgCode { get; set; }
    }
}
