using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class DcArpSoglas
    {
        public DcArpSoglas()
        {
            FsChfSoglasList = new HashSet<FsChfSoglasList>();
            FsLdrCaSoglasList = new HashSet<FsLdrCaSoglasList>();
            FsLdrFesSoglasList = new HashSet<FsLdrFesSoglasList>();
            FsLdrSoglasList = new HashSet<FsLdrSoglasList>();
            FsListsList = new HashSet<FsListsList>();
            FsOipSoglasList = new HashSet<FsOipSoglasList>();
            FsRefoList = new HashSet<FsRefoList>();
        }

        public decimal Docid { get; set; }
        public decimal? Version { get; set; }
        public DateTime? DataStartactive { get; set; }
        public DateTime? DataEndactive { get; set; }
        public string OrgCode { get; set; }
        public string OrgName { get; set; }
        public string Cd { get; set; }
        public string Note { get; set; }
        public string Nm { get; set; }
        public string CaFullname { get; set; }
        public string CaCdSr { get; set; }
        public string Cdsr { get; set; }
        public string Nmsr { get; set; }
        public string LoginGb { get; set; }
        public string LoginRfes { get; set; }
        public string LoginR { get; set; }
        public string LoginOip { get; set; }
        public string FioGb { get; set; }
        public string FioRfes { get; set; }
        public string FioR { get; set; }
        public string FioOip { get; set; }
        public string DepartmentGb { get; set; }
        public string DepartmentRfes { get; set; }
        public string DepartmentR { get; set; }
        public string DepartmentOip { get; set; }
        public string PostfieldR { get; set; }
        public string PostfieldRfes { get; set; }
        public string PostfieldGb { get; set; }
        public string PostfieldOip { get; set; }
        public bool? Scipsoglas { get; set; }
        public string SoglasGb { get; set; }
        public string SoglasRfes { get; set; }
        public string SoglasR { get; set; }
        public string SoglasOip { get; set; }
        public string TpsrTpsubjreport { get; set; }
        public string StrCount { get; set; }
        public string StrCount2 { get; set; }

        public virtual ICollection<FsChfSoglasList> FsChfSoglasList { get; set; }
        public virtual ICollection<FsLdrCaSoglasList> FsLdrCaSoglasList { get; set; }
        public virtual ICollection<FsLdrFesSoglasList> FsLdrFesSoglasList { get; set; }
        public virtual ICollection<FsLdrSoglasList> FsLdrSoglasList { get; set; }
        public virtual ICollection<FsListsList> FsListsList { get; set; }
        public virtual ICollection<FsOipSoglasList> FsOipSoglasList { get; set; }
        public virtual ICollection<FsRefoList> FsRefoList { get; set; }
    }
}
