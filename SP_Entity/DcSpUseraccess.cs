using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class DcSpUseraccess
    {
        public DcSpUseraccess()
        {
            FsUsraccssBkList = new HashSet<FsUsraccssBkList>();
            FsUsraccssExpprtList = new HashSet<FsUsraccssExpprtList>();
        }

        public decimal Docid { get; set; }
        public decimal? Version { get; set; }
        public string Fio { get; set; }
        public string Login { get; set; }
        public string Department { get; set; }
        public string Division { get; set; }
        public string Securitylevel { get; set; }
        public DateTime? Changedate { get; set; }
        public string Note { get; set; }
        public DateTime? DataStartactive { get; set; }
        public DateTime? DataEndactive { get; set; }
        public string Position { get; set; }
        public bool? ExpprtAll { get; set; }
        public bool? BkAll { get; set; }
        public decimal? ExpprtKol { get; set; }
        public decimal? BkKol { get; set; }
        public string BkConcat { get; set; }
        public string ExpprtConcat { get; set; }

        public virtual ICollection<FsUsraccssBkList> FsUsraccssBkList { get; set; }
        public virtual ICollection<FsUsraccssExpprtList> FsUsraccssExpprtList { get; set; }
    }
}
