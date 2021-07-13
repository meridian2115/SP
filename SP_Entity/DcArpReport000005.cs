using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class DcArpReport000005
    {
        public DcArpReport000005()
        {
            FsR1005List = new HashSet<FsR1005List>();
            FsR2005List = new HashSet<FsR2005List>();
            FsR3005List = new HashSet<FsR3005List>();
            FsR4005List = new HashSet<FsR4005List>();
            FsR5005List = new HashSet<FsR5005List>();
            FsTab005List = new HashSet<FsTab005List>();
        }

        public decimal Docid { get; set; }
        public decimal? Version { get; set; }
        public string Ord { get; set; }
        public string PfnLeader { get; set; }
        public string PfnChiefAcc { get; set; }
        public string PfnLeaderOfFes { get; set; }
        public string PfnPostLeader { get; set; }
        public string PfnPostChiefAcc { get; set; }
        public string PfnPostLeaderOf { get; set; }
        public string PfnExecutor { get; set; }
        public string PfnPostExecutor { get; set; }
        public string PfnPhone { get; set; }
        public string HrGrbsNm { get; set; }
        public string HrGrbsRazrez { get; set; }
        public string HrGrbsCd { get; set; }
        public string HrIstType { get; set; }
        public string HrIstGrbsRazrez { get; set; }
        public string HrExErrors { get; set; }
        public string HrTypeInfo { get; set; }
        public DateTime? HrDateForm { get; set; }

        public virtual ICollection<FsR1005List> FsR1005List { get; set; }
        public virtual ICollection<FsR2005List> FsR2005List { get; set; }
        public virtual ICollection<FsR3005List> FsR3005List { get; set; }
        public virtual ICollection<FsR4005List> FsR4005List { get; set; }
        public virtual ICollection<FsR5005List> FsR5005List { get; set; }
        public virtual ICollection<FsTab005List> FsTab005List { get; set; }
    }
}
