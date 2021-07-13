using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class DcArp0503184
    {
        public DcArp0503184()
        {
            FsRepVnk184List = new HashSet<FsRepVnk184List>();
            T01Vnk184 = new HashSet<T01Vnk184>();
        }

        public decimal Docid { get; set; }
        public decimal? Version { get; set; }
        public string TitlePartOrd { get; set; }
        public DateTime? TitlePartPrintDate { get; set; }
        public string TitlePartUnsealed { get; set; }
        public string TitlePartForm { get; set; }
        public string SePfnLeader { get; set; }
        public string SePfnChiefAcc { get; set; }
        public string SePfnLeaderOfFes { get; set; }
        public string SePfnPostLeader { get; set; }
        public string SePfnPostChiefAcc { get; set; }
        public string SePfnPostLeaderOf { get; set; }
        public string SePfnExecutor { get; set; }
        public string SePfnPostExecutor { get; set; }
        public string SePfnPhone { get; set; }
        public decimal? Sumgbrsf { get; set; }
        public decimal? Sumtofkr1gr11 { get; set; }
        public decimal? Sumtotkldoh { get; set; }
        public decimal? Sumgbrsfifd { get; set; }
        public decimal? Sumtofkr2gr11 { get; set; }
        public decimal? Sumotklpoifd { get; set; }
        public DateTime? Logid { get; set; }
        public string PrCodereportform { get; set; }

        public virtual ICollection<FsRepVnk184List> FsRepVnk184List { get; set; }
        public virtual ICollection<T01Vnk184> T01Vnk184 { get; set; }
    }
}
