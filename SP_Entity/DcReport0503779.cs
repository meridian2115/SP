using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class DcReport0503779
    {
        public DcReport0503779()
        {
            FsAciList = new HashSet<FsAciList>();
            FsAfiList = new HashSet<FsAfiList>();
            FsFciList = new HashSet<FsFciList>();
        }

        public decimal Docid { get; set; }
        public decimal? Version { get; set; }
        public string Surrogat { get; set; }
        public string Nameseparatedivision { get; set; }
        public string Codeseparatedivision { get; set; }
        public string Namefounder { get; set; }
        public string Codefounder { get; set; }
        public string Namebodyactingfounder { get; set; }
        public string Codebodyactingfounder { get; set; }
        public string NameKvfo { get; set; }
        public string CodeKvfo { get; set; }
        public decimal? AciTotalC3R11 { get; set; }
        public decimal? AciTotalC4R11 { get; set; }
        public decimal? AciTotalC5R11 { get; set; }
        public decimal? AciTotalC6R11 { get; set; }
        public decimal? AfiTotalC3R21 { get; set; }
        public decimal? AfiTotalC4R21 { get; set; }
        public decimal? AfiTotalC5R21 { get; set; }
        public decimal? AfiTotalC6R21 { get; set; }
        public string AfiTotalC2R2V { get; set; }
        public decimal? FciTotalC3R31 { get; set; }
        public decimal? FciTotalC4R31 { get; set; }
        public decimal? FciTotalC5R31 { get; set; }
        public decimal? FciTotalC6R31 { get; set; }
        public decimal? TotalC3R4 { get; set; }
        public decimal? TotalC4R4 { get; set; }
        public decimal? TotalC5R4 { get; set; }
        public decimal? TotalC6R4 { get; set; }
        public string SePenLeader { get; set; }
        public string SePenChiefAcc { get; set; }
        public string SePenLeaderOfFes { get; set; }
        public string SePenPostLeader { get; set; }
        public string SePenPostChiefAcc { get; set; }
        public string SePenPostLeaderOf { get; set; }
        public string SePenExecutor { get; set; }
        public string SePenPostExecutor { get; set; }
        public string SePenPhone { get; set; }
        public string SeCaCode { get; set; }
        public string SeCaName { get; set; }
        public string SeCaOgrn { get; set; }
        public string SeCaInn { get; set; }
        public string SeCaKpp { get; set; }
        public string SeCaCaLeader { get; set; }
        public string SeCaCaExecutor { get; set; }
        public string SeCaPostCaLeader { get; set; }
        public string SeCaPostCaExecutor { get; set; }
        public string SeCaCaExecutorMail { get; set; }
        public string SeAddress { get; set; }
        public string Ord { get; set; }
        public string Namtip { get; set; }
        public string Subotch { get; set; }
        public bool? SubDiv { get; set; }

        public virtual ICollection<FsAciList> FsAciList { get; set; }
        public virtual ICollection<FsAfiList> FsAfiList { get; set; }
        public virtual ICollection<FsFciList> FsFciList { get; set; }
    }
}
