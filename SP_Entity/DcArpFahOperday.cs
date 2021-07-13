using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class DcArpFahOperday
    {
        public DcArpFahOperday()
        {
            FsInfoDayTechList = new HashSet<FsInfoDayTechList>();
            FsSysoperdayList = new HashSet<FsSysoperdayList>();
            FsUsroperdayList = new HashSet<FsUsroperdayList>();
        }

        public decimal Docid { get; set; }
        public decimal? Version { get; set; }
        public DateTime? DataStartactive { get; set; }
        public DateTime? DataEndactive { get; set; }
        public string Rfp { get; set; }
        public string Inst { get; set; }
        public string Dept { get; set; }
        public string Login { get; set; }
        public string Usr { get; set; }
        public string Instcd { get; set; }
        public string CloseDayForSystem { get; set; }
        public string Tofk { get; set; }
        public string KofkSelf { get; set; }
        public string ErrorProc { get; set; }
        public string ErrorProcClose { get; set; }
        public string POebsLink { get; set; }
        public string Tfield { get; set; }
        public string Tfield1 { get; set; }
        public DateTime? Today { get; set; }
        public bool? RoleLogical { get; set; }
        public string OpenTofk { get; set; }

        public virtual ICollection<FsInfoDayTechList> FsInfoDayTechList { get; set; }
        public virtual ICollection<FsSysoperdayList> FsSysoperdayList { get; set; }
        public virtual ICollection<FsUsroperdayList> FsUsroperdayList { get; set; }
    }
}
