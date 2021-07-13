using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class DcReport0503178
    {
        public DcReport0503178()
        {
            FsAciTab1List = new HashSet<FsAciTab1List>();
            FsAfiTab2List = new HashSet<FsAfiTab2List>();
        }

        public decimal Docid { get; set; }
        public decimal? Version { get; set; }
        public string HrNameKvfo { get; set; }
        public string HrKvfoCode { get; set; }
        public string HrSubotch { get; set; }
        public string HrPrp { get; set; }
        public decimal? AciTotalC3R2 { get; set; }
        public decimal? AciTotalC4R2 { get; set; }
        public decimal? AciTotalC5R2 { get; set; }
        public decimal? AciTotalC6R2 { get; set; }
        public decimal? AfiTotalC3R4 { get; set; }
        public decimal? AfiTotalC4R4 { get; set; }
        public decimal? AfiTotalC5R4 { get; set; }
        public decimal? AfiTotalC6R4 { get; set; }
        public decimal? TotalC3R5 { get; set; }
        public decimal? TotalC4R5 { get; set; }
        public decimal? TotalC6R5 { get; set; }
        public decimal? TotalC5R5 { get; set; }
        public string Surrogat { get; set; }
        public string PfnLeader { get; set; }
        public string PfnChiefAcc { get; set; }
        public string PfnLeaderOfFes { get; set; }
        public string PfnPostLeader { get; set; }
        public string PfnPostChiefAcc { get; set; }
        public string PfnPostLeaderOf { get; set; }
        public string PfnExecutor { get; set; }
        public string PfnPostExecutor { get; set; }
        public string PfnPhone { get; set; }
        public string Ord { get; set; }

        public virtual ICollection<FsAciTab1List> FsAciTab1List { get; set; }
        public virtual ICollection<FsAfiTab2List> FsAfiTab2List { get; set; }
    }
}
