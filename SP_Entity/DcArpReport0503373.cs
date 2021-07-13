using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class DcArpReport0503373
    {
        public DcArpReport0503373()
        {
            FsTabT10503373List = new HashSet<FsTabT10503373List>();
            FsTabT20503373List = new HashSet<FsTabT20503373List>();
            FsTabT30503373List = new HashSet<FsTabT30503373List>();
            FsTabT40503373List = new HashSet<FsTabT40503373List>();
            FsTabT50503373List = new HashSet<FsTabT50503373List>();
            FsTabT60503373List = new HashSet<FsTabT60503373List>();
        }

        public decimal Docid { get; set; }
        public decimal? Version { get; set; }
        public string Ord { get; set; }
        public decimal? Ca2R5 { get; set; }
        public decimal? Cb2R5 { get; set; }
        public string PfnLeader { get; set; }
        public string PfnChiefAcc { get; set; }
        public string PfnLeaderOfFes { get; set; }
        public string PfnPostLeader { get; set; }
        public string PfnPostChiefAcc { get; set; }
        public string PfnPostLeaderOf { get; set; }
        public string PfnExecutor { get; set; }
        public string PfnPostExecutor { get; set; }
        public string PfnPhone { get; set; }
        public decimal? Ca3R2 { get; set; }
        public decimal? Ca4R2 { get; set; }
        public decimal? Ca5R2 { get; set; }
        public decimal? Ca3R4 { get; set; }
        public decimal? Ca4R4 { get; set; }
        public decimal? Ca5R4 { get; set; }
        public string ExecutorTel { get; set; }

        public virtual ICollection<FsTabT10503373List> FsTabT10503373List { get; set; }
        public virtual ICollection<FsTabT20503373List> FsTabT20503373List { get; set; }
        public virtual ICollection<FsTabT30503373List> FsTabT30503373List { get; set; }
        public virtual ICollection<FsTabT40503373List> FsTabT40503373List { get; set; }
        public virtual ICollection<FsTabT50503373List> FsTabT50503373List { get; set; }
        public virtual ICollection<FsTabT60503373List> FsTabT60503373List { get; set; }
    }
}
