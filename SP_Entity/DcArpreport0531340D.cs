using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class DcArpreport0531340D
    {
        public DcArpreport0531340D()
        {
            FsR05313401List = new HashSet<FsR05313401List>();
            FsR05313402List = new HashSet<FsR05313402List>();
        }

        public decimal Docid { get; set; }
        public decimal? Version { get; set; }
        public string HrPnfLeader { get; set; }
        public string HrPnfChiefAcc { get; set; }
        public string HrPnfLeaderOfFes { get; set; }
        public string HrPnfPostLeader { get; set; }
        public string HrPnfPostChiefAcc { get; set; }
        public string HrPnfPostLeaderOf { get; set; }
        public string HrPnfExecutor { get; set; }
        public string HrPnfPostExecutor { get; set; }
        public string HrPnfPhone { get; set; }
        public string HrOrd { get; set; }
        public string HrNamtip { get; set; }
        public string HrKodTofk { get; set; }
        public string HrNameTofk { get; set; }
        public string HrBudgLevel { get; set; }
        public string HrKodUbp { get; set; }
        public string HrNameUbp { get; set; }
        public string HrPrizSo { get; set; }
        public string HrSubotch { get; set; }
        public string HrPrizOb { get; set; }
        public string HrTelIsp { get; set; }
        public string HrCommenty { get; set; }
        public string HrTypeOrg { get; set; }
        public string Surrogat { get; set; }
        public string I1G1 { get; set; }
        public string I1G2 { get; set; }
        public string I1G3 { get; set; }
        public string I1G4 { get; set; }
        public decimal? I1G5 { get; set; }
        public string I1Gs { get; set; }
        public string I1Kbk1 { get; set; }
        public string I1Kbk2 { get; set; }
        public string I1Kbk3 { get; set; }
        public string I1Kbk4 { get; set; }
        public string I1Kbk51 { get; set; }
        public string I2G1 { get; set; }
        public string I2G2 { get; set; }
        public string I2G3 { get; set; }
        public string I2G4 { get; set; }
        public decimal? I2G5 { get; set; }
        public string I2Gs { get; set; }
        public string I2Kbk1 { get; set; }
        public string I2Kbk2 { get; set; }
        public string I2Kbk3 { get; set; }
        public string I2Kbk4 { get; set; }
        public string I2Kbk5 { get; set; }

        public virtual ICollection<FsR05313401List> FsR05313401List { get; set; }
        public virtual ICollection<FsR05313402List> FsR05313402List { get; set; }
    }
}
