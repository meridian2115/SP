using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class DcArpreport0503155
    {
        public DcArpreport0503155()
        {
            FsT010155List = new HashSet<FsT010155List>();
            FsT200155List = new HashSet<FsT200155List>();
            FsT500155List = new HashSet<FsT500155List>();
            FsT520155List = new HashSet<FsT520155List>();
            FsT620155List = new HashSet<FsT620155List>();
            FsT710155List = new HashSet<FsT710155List>();
            FsT720155List = new HashSet<FsT720155List>();
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
        public string S010R1 { get; set; }
        public string S010R2 { get; set; }
        public string S010R3 { get; set; }
        public decimal? S010R4 { get; set; }
        public decimal? S010R5 { get; set; }
        public decimal? S010R6 { get; set; }
        public decimal? S010R7 { get; set; }
        public string S200R1 { get; set; }
        public string S200R2 { get; set; }
        public string S200R3 { get; set; }
        public decimal? S200R4 { get; set; }
        public decimal? S200R5 { get; set; }
        public decimal? S200R6 { get; set; }
        public decimal? S200R7 { get; set; }
        public string S450R1 { get; set; }
        public string S450R2 { get; set; }
        public string S450R3 { get; set; }
        public decimal? S450R4 { get; set; }
        public decimal? S450R5 { get; set; }
        public decimal? S450R6 { get; set; }
        public decimal? S450R7 { get; set; }
        public string S500R1 { get; set; }
        public string S500R2 { get; set; }
        public string S500R3 { get; set; }
        public decimal? S500R4 { get; set; }
        public decimal? S500R5 { get; set; }
        public decimal? S500R6 { get; set; }
        public decimal? S500R7 { get; set; }
        public string S520R1 { get; set; }
        public string S520R2 { get; set; }
        public string S520R3 { get; set; }
        public decimal? S520R4 { get; set; }
        public decimal? S520R5 { get; set; }
        public decimal? S520R6 { get; set; }
        public decimal? S520R7 { get; set; }
        public string S620R1 { get; set; }
        public string S620R2 { get; set; }
        public string S620R3 { get; set; }
        public decimal? S620R4 { get; set; }
        public decimal? S620R5 { get; set; }
        public decimal? S620R6 { get; set; }
        public decimal? S620R7 { get; set; }
        public string S700R1 { get; set; }
        public string S700R2 { get; set; }
        public string S700R3 { get; set; }
        public decimal? S700R4 { get; set; }
        public decimal? S700R5 { get; set; }
        public decimal? S700R6 { get; set; }
        public decimal? S700R7 { get; set; }
        public string S710R1 { get; set; }
        public string S710R2 { get; set; }
        public string S710R3 { get; set; }
        public decimal? S710R4 { get; set; }
        public decimal? S710R5 { get; set; }
        public decimal? S710R6 { get; set; }
        public decimal? S710R7 { get; set; }
        public string S720R1 { get; set; }
        public string S720R2 { get; set; }
        public string S720R3 { get; set; }
        public decimal? S720R4 { get; set; }
        public decimal? S720R5 { get; set; }
        public decimal? S720R6 { get; set; }
        public decimal? S720R7 { get; set; }
        public string S800R1 { get; set; }
        public string S800R2 { get; set; }
        public string S800R3 { get; set; }
        public decimal? S800R4 { get; set; }
        public decimal? S800R5 { get; set; }
        public decimal? S800R6 { get; set; }
        public decimal? S800R7 { get; set; }
        public string S825R1 { get; set; }
        public string S825R2 { get; set; }
        public string S825R3 { get; set; }
        public decimal? S825R4 { get; set; }
        public decimal? S825R5 { get; set; }
        public decimal? S825R6 { get; set; }
        public decimal? S825R7 { get; set; }
        public string S826R1 { get; set; }
        public string S826R2 { get; set; }
        public string S826R3 { get; set; }
        public decimal? S826R4 { get; set; }
        public decimal? S826R5 { get; set; }
        public decimal? S826R6 { get; set; }
        public decimal? S826R7 { get; set; }

        public virtual ICollection<FsT010155List> FsT010155List { get; set; }
        public virtual ICollection<FsT200155List> FsT200155List { get; set; }
        public virtual ICollection<FsT500155List> FsT500155List { get; set; }
        public virtual ICollection<FsT520155List> FsT520155List { get; set; }
        public virtual ICollection<FsT620155List> FsT620155List { get; set; }
        public virtual ICollection<FsT710155List> FsT710155List { get; set; }
        public virtual ICollection<FsT720155List> FsT720155List { get; set; }
    }
}
