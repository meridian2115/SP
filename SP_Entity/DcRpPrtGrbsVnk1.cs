using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class DcRpPrtGrbsVnk1
    {
        public DcRpPrtGrbsVnk1()
        {
            FsT01GrbsVnk1List = new HashSet<FsT01GrbsVnk1List>();
            FsT02GrbsVnk1List = new HashSet<FsT02GrbsVnk1List>();
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
        public string HrUserlogin { get; set; }
        public string HrUserfio { get; set; }
        public string HrUserposition { get; set; }
        public string HrUserorg { get; set; }
        public string HrUserorgunit { get; set; }
        public string Surrogat { get; set; }
        public string I1Dim1 { get; set; }
        public decimal? I1Dat2 { get; set; }
        public decimal? I1Dat3 { get; set; }
        public decimal? I1Dat4 { get; set; }
        public decimal? I1Dat5 { get; set; }
        public decimal? I1Dat6 { get; set; }
        public decimal? I1Dat7 { get; set; }
        public decimal? I1Dat8 { get; set; }
        public decimal? I1Dat9 { get; set; }
        public decimal? I1Dat10 { get; set; }
        public decimal? I1Dat11 { get; set; }
        public string I2Dim1 { get; set; }
        public decimal? I2Dat2 { get; set; }
        public decimal? I2Dat3 { get; set; }
        public decimal? I2Dat4 { get; set; }
        public decimal? I2Dat5 { get; set; }
        public decimal? I2Dat6 { get; set; }
        public decimal? I2Dat7 { get; set; }
        public decimal? I2Dat8 { get; set; }
        public decimal? I2Dat9 { get; set; }
        public decimal? I2Dat10 { get; set; }
        public decimal? I2Dat11 { get; set; }
        public DateTime? Logid { get; set; }
        public DateTime? PrintDate { get; set; }
        public string Unsealed { get; set; }
        public string PrCodereportform { get; set; }

        public virtual ICollection<FsT01GrbsVnk1List> FsT01GrbsVnk1List { get; set; }
        public virtual ICollection<FsT02GrbsVnk1List> FsT02GrbsVnk1List { get; set; }
    }
}
