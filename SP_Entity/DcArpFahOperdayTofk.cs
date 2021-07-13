using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class DcArpFahOperdayTofk
    {
        public DcArpFahOperdayTofk()
        {
            FsInfoDayTech1List = new HashSet<FsInfoDayTech1List>();
            Tofkoperday = new HashSet<Tofkoperday>();
        }

        public decimal Docid { get; set; }
        public decimal? Version { get; set; }
        public DateTime? DataStartactive { get; set; }
        public DateTime? DataEndactive { get; set; }
        public string Rfp { get; set; }
        public string Instcd { get; set; }
        public string Tofk { get; set; }
        public string KofkSelf { get; set; }
        public string ErrorProc { get; set; }
        public string POebsLink { get; set; }
        public DateTime? Today { get; set; }
        public bool? RoleLogical { get; set; }
        public string Login { get; set; }

        public virtual ICollection<FsInfoDayTech1List> FsInfoDayTech1List { get; set; }
        public virtual ICollection<Tofkoperday> Tofkoperday { get; set; }
    }
}
