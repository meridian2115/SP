using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class DcTypesAnFeature
    {
        public decimal Docid { get; set; }
        public decimal? Version { get; set; }
        public string CodeAnFeature { get; set; }
        public string NameAnFeature { get; set; }
        public string NameDirDoc { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public string FieldKey { get; set; }
        public string FieldName { get; set; }
        public string Ap1Dt { get; set; }
    }
}
