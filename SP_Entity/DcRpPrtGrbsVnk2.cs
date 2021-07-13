using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class DcRpPrtGrbsVnk2
    {
        public DcRpPrtGrbsVnk2()
        {
            FsT01GrbsVnk2List = new HashSet<FsT01GrbsVnk2List>();
            FsT02GrbsVnk2List = new HashSet<FsT02GrbsVnk2List>();
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
        public DateTime? Logid { get; set; }
        public DateTime? PrintDate { get; set; }
        public string Unsealed { get; set; }
        public string PrCodereportform { get; set; }

        public virtual ICollection<FsT01GrbsVnk2List> FsT01GrbsVnk2List { get; set; }
        public virtual ICollection<FsT02GrbsVnk2List> FsT02GrbsVnk2List { get; set; }
    }
}
