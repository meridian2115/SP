using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class DcRpPrtGvfVnk1
    {
        public DcRpPrtGvfVnk1()
        {
            FsT01PrtGvfVnk1List = new HashSet<FsT01PrtGvfVnk1List>();
            FsT02PrtGvfVnk1List = new HashSet<FsT02PrtGvfVnk1List>();
            FsT03PrtGvfVnk1List = new HashSet<FsT03PrtGvfVnk1List>();
            FsT04PrtGvfVnk1List = new HashSet<FsT04PrtGvfVnk1List>();
        }

        public decimal Docid { get; set; }
        public decimal? Version { get; set; }
        public DateTime? Logid { get; set; }
        public DateTime? PrintDate { get; set; }
        public string Unsealed { get; set; }
        public string PrCodereportform { get; set; }
        public string Ord { get; set; }
        public string SePfnLeader { get; set; }
        public string SePfnChiefAcc { get; set; }
        public string SePfnLeaderOfFes { get; set; }
        public string SePfnPostLeader { get; set; }
        public string SePfnPostChiefAcc { get; set; }
        public string SePfnPostLeaderOf { get; set; }
        public string SePfnExecutor { get; set; }
        public string SePfnPostExecutor { get; set; }
        public string SePfnPhone { get; set; }

        public virtual ICollection<FsT01PrtGvfVnk1List> FsT01PrtGvfVnk1List { get; set; }
        public virtual ICollection<FsT02PrtGvfVnk1List> FsT02PrtGvfVnk1List { get; set; }
        public virtual ICollection<FsT03PrtGvfVnk1List> FsT03PrtGvfVnk1List { get; set; }
        public virtual ICollection<FsT04PrtGvfVnk1List> FsT04PrtGvfVnk1List { get; set; }
    }
}
