using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class DcReport0504833
    {
        public DcReport0504833()
        {
            FsTable0504833List = new HashSet<FsTable0504833List>();
        }

        public decimal Docid { get; set; }
        public decimal? Version { get; set; }
        public DateTime? ReportingDate { get; set; }
        public string SubjectReport { get; set; }
        public string Okpo { get; set; }
        public string StructuralSubdivision { get; set; }
        public string UserPosition { get; set; }
        public string UserName { get; set; }
        public string UserTelephone { get; set; }
        public DateTime? DateOfReport { get; set; }
        public string ChiefAccountant { get; set; }
        public DateTime? DateRecognition { get; set; }
        public string NameRegister { get; set; }

        public virtual ICollection<FsTable0504833List> FsTable0504833List { get; set; }
    }
}
