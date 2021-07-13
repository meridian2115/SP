using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class DcArpReport0521441
    {
        public DcArpReport0521441()
        {
            FsT10521441List = new HashSet<FsT10521441List>();
            FsT20521441List = new HashSet<FsT20521441List>();
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
        public string HrNmsbrf { get; set; }
        public string Surrogat { get; set; }
        public decimal? ItogoG15 { get; set; }
        public decimal? ItogoG16 { get; set; }
        public decimal? ItogoG17 { get; set; }
        public decimal? ItogoG18 { get; set; }
        public decimal? SaldoG15 { get; set; }
        public decimal? SaldoG16 { get; set; }
        public decimal? SaldoG17 { get; set; }
        public decimal? SaldoG18 { get; set; }
        public string OstatokG1 { get; set; }
        public string OstatokG21 { get; set; }
        public string OstatokG22 { get; set; }
        public decimal? OstatokG3 { get; set; }
        public decimal? OstatokG4 { get; set; }
        public decimal? OstatokG5 { get; set; }
        public decimal? OstatokG6 { get; set; }
        public decimal? OstatokG7 { get; set; }
        public decimal? OstatokG8 { get; set; }
        public decimal? OstatokG9 { get; set; }
        public decimal? OstatokG10 { get; set; }
        public decimal? OstatokG11 { get; set; }
        public decimal? OstatokG12 { get; set; }
        public decimal? OstatokG13 { get; set; }
        public decimal? OstatokG14 { get; set; }
        public decimal? OstatokG15 { get; set; }
        public decimal? OstatokG16 { get; set; }
        public decimal? OstatokG17 { get; set; }
        public decimal? OstatokG18 { get; set; }

        public virtual ICollection<FsT10521441List> FsT10521441List { get; set; }
        public virtual ICollection<FsT20521441List> FsT20521441List { get; set; }
    }
}
