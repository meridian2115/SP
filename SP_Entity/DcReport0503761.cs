using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class DcReport0503761
    {
        public DcReport0503761()
        {
            FsQtyinstn0503761List = new HashSet<FsQtyinstn0503761List>();
        }

        public decimal Docid { get; set; }
        public decimal? Version { get; set; }
        public decimal? TtlqtyinstC3R2 { get; set; }
        public decimal? TtlqtyinstC4R2 { get; set; }
        public decimal? TtlqtyinstC5R2 { get; set; }
        public decimal? TtlqtyinstC6R2 { get; set; }
        public string EntNameseparatedivision { get; set; }
        public string EntCodeseparatedivision { get; set; }
        public string EntNamefounder { get; set; }
        public string EntCodefounder { get; set; }
        public string EntNamebodyactfounder { get; set; }
        public string EntCodebodyactfounder { get; set; }
        public string EntOkpobodyactfounder { get; set; }
        public bool? EntSubDiv { get; set; }
        public string PfnLeader { get; set; }
        public string PfnChiefAcc { get; set; }
        public string PfnLeaderOfFes { get; set; }
        public string PfnPostLeader { get; set; }
        public string PfnPostChiefAcc { get; set; }
        public string PfnPostLeaderOf { get; set; }
        public string PfnExecutor { get; set; }
        public string PfnPostExecutor { get; set; }
        public string PfnPhone { get; set; }
        public string SysNamtip { get; set; }
        public string SysOrd { get; set; }
        public string Period { get; set; }

        public virtual ICollection<FsQtyinstn0503761List> FsQtyinstn0503761List { get; set; }
    }
}
