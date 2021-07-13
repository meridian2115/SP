using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class DcArpReport0503793
    {
        public DcArpReport0503793()
        {
            FsPrint0503793List = new HashSet<FsPrint0503793List>();
            FsT10503793List = new HashSet<FsT10503793List>();
            FsT2ibo0503793List = new HashSet<FsT2ibo0503793List>();
            FsT3inn0503793List = new HashSet<FsT3inn0503793List>();
            FsT4all0503793List = new HashSet<FsT4all0503793List>();
        }

        public decimal Docid { get; set; }
        public decimal? Version { get; set; }
        public string SnLeader { get; set; }
        public string SnChiefAcc { get; set; }
        public string SnLeaderOfFes { get; set; }
        public string SnPostLeader { get; set; }
        public string SnPostChiefAcc { get; set; }
        public string SnPostLeaderOf { get; set; }
        public string SnExecutor { get; set; }
        public string SnPostExecutor { get; set; }
        public string SnPhone { get; set; }
        public string Ord { get; set; }
        public DateTime? Dateminusday { get; set; }
        public decimal? TotalItog { get; set; }
        public decimal? OverdueItog { get; set; }
        public decimal? TotalEndpItog { get; set; }
        public decimal? ConfnfItog { get; set; }
        public decimal? ArrearsItog { get; set; }
        public decimal? RepayfbItog { get; set; }
        public decimal? ScheduledDebtEndpItog { get; set; }
        public string Nameseparatedivision { get; set; }
        public string Codeseparatedivision { get; set; }
        public string Namefounder { get; set; }
        public string Codefounder { get; set; }
        public string Namebodyactingfounder { get; set; }
        public string Codebodyactingfounder { get; set; }
        public string NameKvfo { get; set; }
        public string CodeKvfo { get; set; }
        public decimal? Year { get; set; }

        public virtual ICollection<FsPrint0503793List> FsPrint0503793List { get; set; }
        public virtual ICollection<FsT10503793List> FsT10503793List { get; set; }
        public virtual ICollection<FsT2ibo0503793List> FsT2ibo0503793List { get; set; }
        public virtual ICollection<FsT3inn0503793List> FsT3inn0503793List { get; set; }
        public virtual ICollection<FsT4all0503793List> FsT4all0503793List { get; set; }
    }
}
