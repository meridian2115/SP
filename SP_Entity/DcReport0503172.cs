using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class DcReport0503172
    {
        public DcReport0503172()
        {
            FsR1T10503172List = new HashSet<FsR1T10503172List>();
            FsR2T20503172List = new HashSet<FsR2T20503172List>();
            FsR3T30503172List = new HashSet<FsR3T30503172List>();
            FsR4T40503172List = new HashSet<FsR4T40503172List>();
        }

        public decimal Docid { get; set; }
        public decimal? Version { get; set; }
        public string HrSignLeader { get; set; }
        public string HrSignChiefAcc { get; set; }
        public string HrSignLeaderOfFes { get; set; }
        public string HrSignPostLeader { get; set; }
        public string HrSignPostChiefAcc { get; set; }
        public string HrSignPostLeaderOf { get; set; }
        public string HrSignExecutor { get; set; }
        public string HrSignPostExecutor { get; set; }
        public string HrSignPhone { get; set; }
        public decimal? R1C2R1 { get; set; }
        public decimal? R1C3R1 { get; set; }
        public decimal? R2C2R2 { get; set; }
        public decimal? R2C3R2 { get; set; }
        public decimal? R4C3R4 { get; set; }
        public decimal? R4C4R4 { get; set; }
        public string Ord { get; set; }
        public string Tel { get; set; }

        public virtual ICollection<FsR1T10503172List> FsR1T10503172List { get; set; }
        public virtual ICollection<FsR2T20503172List> FsR2T20503172List { get; set; }
        public virtual ICollection<FsR3T30503172List> FsR3T30503172List { get; set; }
        public virtual ICollection<FsR4T40503172List> FsR4T40503172List { get; set; }
    }
}
