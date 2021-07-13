using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class DcArp0521413OtchetO
    {
        public DcArp0521413OtchetO()
        {
            FsBakvsList = new HashSet<FsBakvsList>();
            FsBakvsTmpList = new HashSet<FsBakvsTmpList>();
            FsLboList = new HashSet<FsLboList>();
            FsLboTmpList = new HashSet<FsLboTmpList>();
        }

        public decimal Docid { get; set; }
        public decimal? Version { get; set; }
        public decimal? SumTabl1Row1 { get; set; }
        public decimal? SumTabl1Row2 { get; set; }
        public decimal? SumTabl1Row3 { get; set; }
        public decimal? SumTabl1Row4 { get; set; }
        public decimal? SumTabl1Row5 { get; set; }
        public decimal? SumTabl1Row6 { get; set; }
        public decimal? SumTabl2Row1 { get; set; }
        public decimal? SumTabl2Row2 { get; set; }
        public decimal? SumTabl2Row3 { get; set; }
        public decimal? SumTabl2Row4 { get; set; }
        public decimal? SumTabl2Row5 { get; set; }
        public decimal? SumTabl2Row6 { get; set; }
        public string HrNameKvfo { get; set; }
        public string HrKvfoCode { get; set; }
        public string HrSubotch { get; set; }
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
        public string ExecutorTel { get; set; }
        public string NameTofk { get; set; }
        public string CodeTofk { get; set; }

        public virtual ICollection<FsBakvsList> FsBakvsList { get; set; }
        public virtual ICollection<FsBakvsTmpList> FsBakvsTmpList { get; set; }
        public virtual ICollection<FsLboList> FsLboList { get; set; }
        public virtual ICollection<FsLboTmpList> FsLboTmpList { get; set; }
    }
}
