using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class DcArpPrt0503320
    {
        public DcArpPrt0503320()
        {
            FsRepVnk320List = new HashSet<FsRepVnk320List>();
            FsT01Vnk320List = new HashSet<FsT01Vnk320List>();
        }

        public decimal Docid { get; set; }
        public decimal? Version { get; set; }
        public DateTime? Logid { get; set; }
        public string PrCodereportform { get; set; }
        public DateTime? PrintDate { get; set; }
        public string Unsealed { get; set; }
        public string CdRf { get; set; }
        public string SePfnLeader { get; set; }
        public string SePfnChiefAcc { get; set; }
        public string SePfnLeaderOfFes { get; set; }
        public string SePfnPostLeader { get; set; }
        public string SePfnPostChiefAcc { get; set; }
        public string SePfnPostLeaderOf { get; set; }
        public string SePfnExecutor { get; set; }
        public string SePfnPostExecutor { get; set; }
        public string SePfnPhone { get; set; }

        public virtual ICollection<FsRepVnk320List> FsRepVnk320List { get; set; }
        public virtual ICollection<FsT01Vnk320List> FsT01Vnk320List { get; set; }
    }
}
