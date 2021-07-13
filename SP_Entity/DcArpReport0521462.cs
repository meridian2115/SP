using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class DcArpReport0521462
    {
        public DcArpReport0521462()
        {
            FsTab462List = new HashSet<FsTab462List>();
        }

        public decimal Docid { get; set; }
        public decimal? Version { get; set; }
        public string System { get; set; }
        public string System1 { get; set; }
        public string Ord { get; set; }
        public decimal? Summatotal { get; set; }
        public string PfnLeader { get; set; }
        public string PfnChiefAcc { get; set; }
        public string PfnLeaderOfFes { get; set; }
        public string PfnPostLeader { get; set; }
        public string PfnPostChiefAcc { get; set; }
        public string PfnPostLeaderOf { get; set; }
        public string PfnExecutor { get; set; }
        public string PfnPostExecutor { get; set; }
        public string PfnPhone { get; set; }
        public string Telephone { get; set; }
        public string CodeTofk { get; set; }
        public string NameTofk { get; set; }
        public DateTime? StartYearDate { get; set; }
        public string Typeperiod { get; set; }

        public virtual ICollection<FsTab462List> FsTab462List { get; set; }
    }
}
