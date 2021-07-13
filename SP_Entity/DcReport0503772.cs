using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class DcReport0503772
    {
        public DcReport0503772()
        {
            FsR1T105037722List = new HashSet<FsR1T105037722List>();
            FsR1T10503772List = new HashSet<FsR1T10503772List>();
            FsR2T205037722List = new HashSet<FsR2T205037722List>();
            FsR2T20503772List = new HashSet<FsR2T20503772List>();
            FsR3T30503772List = new HashSet<FsR3T30503772List>();
        }

        public decimal Docid { get; set; }
        public decimal? Version { get; set; }
        public string HrNameseparatedivision { get; set; }
        public string HrCodeseparatedivision { get; set; }
        public string HrNamefounder { get; set; }
        public string HrCodefounder { get; set; }
        public string HrNamebodyactingfounder { get; set; }
        public string HrCodebodyactingfounder { get; set; }
        public string HrOrd { get; set; }
        public decimal? R1C2R1 { get; set; }
        public decimal? R1C3R1 { get; set; }
        public decimal? R2C2R2 { get; set; }
        public decimal? R2C3R2 { get; set; }
        public string PenLeader { get; set; }
        public string PenChiefAcc { get; set; }
        public string PenLeaderOfFes { get; set; }
        public string PenPostLeader { get; set; }
        public string PenPostChiefAcc { get; set; }
        public string PenPostLeaderOf { get; set; }
        public string PenExecutor { get; set; }
        public string PenPostExecutor { get; set; }
        public string PenPhone { get; set; }

        public virtual ICollection<FsR1T105037722List> FsR1T105037722List { get; set; }
        public virtual ICollection<FsR1T10503772List> FsR1T10503772List { get; set; }
        public virtual ICollection<FsR2T205037722List> FsR2T205037722List { get; set; }
        public virtual ICollection<FsR2T20503772List> FsR2T20503772List { get; set; }
        public virtual ICollection<FsR3T30503772List> FsR3T30503772List { get; set; }
    }
}
