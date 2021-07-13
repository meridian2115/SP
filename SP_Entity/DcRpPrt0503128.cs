using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class DcRpPrt0503128
    {
        public DcRpPrt0503128()
        {
            FsRepVnk128List = new HashSet<FsRepVnk128List>();
            T01Vnk128 = new HashSet<T01Vnk128>();
        }

        public decimal Docid { get; set; }
        public decimal? Version { get; set; }
        public string Protocolnumber { get; set; }
        public string LkpsetsrprtgCd { get; set; }
        public string LkpsetsrprtgNm { get; set; }
        public string LkpsbjtrptgCd { get; set; }
        public string Indicatorsreport { get; set; }
        public string LkpsbjtrptgNm { get; set; }
        public string Lookupemployeescode { get; set; }
        public string Lookupemployeesname { get; set; }
        public DateTime? Formationdate { get; set; }
        public DateTime? Reportdate { get; set; }
        public decimal? C4 { get; set; }
        public decimal? C5 { get; set; }
        public decimal? C6 { get; set; }
        public decimal? C4910 { get; set; }
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
        public DateTime? Logid { get; set; }
        public string PrCodereportform { get; set; }

        public virtual ICollection<FsRepVnk128List> FsRepVnk128List { get; set; }
        public virtual ICollection<T01Vnk128> T01Vnk128 { get; set; }
    }
}
