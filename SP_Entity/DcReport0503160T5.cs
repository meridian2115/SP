using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class DcReport0503160T5
    {
        public DcReport0503160T5()
        {
            FsS5T50503160List = new HashSet<FsS5T50503160List>();
            FsS5TCs0503160List = new HashSet<FsS5TCs0503160List>();
        }

        public decimal Docid { get; set; }
        public decimal? Version { get; set; }
        public string Surrogat { get; set; }
        public string Ord { get; set; }
        public string HrSingLeader { get; set; }
        public string HrSingChiefAcc { get; set; }
        public string HrSingLeaderOfFes { get; set; }
        public string HrSingPostLeader { get; set; }
        public string HrSingPostChiefAcc { get; set; }
        public string HrSingPostLeaderOf { get; set; }
        public string HrSingExecutor { get; set; }
        public string HrSingPostExecutor { get; set; }
        public string HrSingPhone { get; set; }

        public virtual ICollection<FsS5T50503160List> FsS5T50503160List { get; set; }
        public virtual ICollection<FsS5TCs0503160List> FsS5TCs0503160List { get; set; }
    }
}
