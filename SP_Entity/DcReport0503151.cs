using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class DcReport0503151
    {
        public DcReport0503151()
        {
            FsT010151List = new HashSet<FsT010151List>();
            FsT020151List = new HashSet<FsT020151List>();
            FsT520151List = new HashSet<FsT520151List>();
            FsT620151List = new HashSet<FsT620151List>();
            FsT710151List = new HashSet<FsT710151List>();
            FsT720151List = new HashSet<FsT720151List>();
        }

        public decimal Docid { get; set; }
        public decimal? Version { get; set; }
        public string R010Name { get; set; }
        public string R010StrKod { get; set; }
        public string R010KbkIst { get; set; }
        public string R010TypeKbk { get; set; }
        public decimal? R010BIst { get; set; }
        public decimal? R010VremIst { get; set; }
        public decimal? R010ItogoIst { get; set; }
        public string R020Name { get; set; }
        public string R020StrKod { get; set; }
        public string R020KbkIst { get; set; }
        public string R020TypeKbk { get; set; }
        public decimal? R020BIst { get; set; }
        public decimal? R020VremIst { get; set; }
        public decimal? R020ItogoIst { get; set; }
        public string R500Name { get; set; }
        public string R500StrKod { get; set; }
        public string R500KbkIst { get; set; }
        public string R500TypeKbk { get; set; }
        public decimal? R500BIst { get; set; }
        public decimal? R500VremIst { get; set; }
        public decimal? R500ItogoIst { get; set; }
        public string R520Name { get; set; }
        public string R520StrKod { get; set; }
        public string R520KbkIst { get; set; }
        public string R520TypeKbk { get; set; }
        public decimal? R520BIst { get; set; }
        public decimal? R520VremIst { get; set; }
        public decimal? R520ItogoIst { get; set; }
        public string R620Name { get; set; }
        public string R620StrKod { get; set; }
        public string R620KbkIst { get; set; }
        public string R620TypeKbk { get; set; }
        public decimal? R620BIst { get; set; }
        public decimal? R620VremIst { get; set; }
        public decimal? R620ItogoIst { get; set; }
        public string R700Name { get; set; }
        public string R700StrKod { get; set; }
        public string R700KbkIst { get; set; }
        public string R700TypeKbk { get; set; }
        public decimal? R700BIst { get; set; }
        public decimal? R700VremIst { get; set; }
        public decimal? R700ItogoIst { get; set; }
        public string R710Name { get; set; }
        public string R710StrKod { get; set; }
        public string R710KbkIst { get; set; }
        public string R710TypeKbk { get; set; }
        public decimal? R710BIst { get; set; }
        public decimal? R710VremIst { get; set; }
        public decimal? R710ItogoIst { get; set; }
        public string R720Name { get; set; }
        public string R720StrKod { get; set; }
        public string R720KbkIst { get; set; }
        public string R720TypeKbk { get; set; }
        public decimal? R720BIst { get; set; }
        public decimal? R720VremIst { get; set; }
        public decimal? R720ItogoIst { get; set; }
        public string R800Name { get; set; }
        public string R800StrKod { get; set; }
        public string R800KbkIst { get; set; }
        public string R800TypeKbk { get; set; }
        public decimal? R800BIst { get; set; }
        public decimal? R800VremIst { get; set; }
        public decimal? R800ItogoIst { get; set; }
        public string R825Name { get; set; }
        public string R825StrKod { get; set; }
        public string R825KbkIst { get; set; }
        public string R825TypeKbk { get; set; }
        public decimal? R825BIst { get; set; }
        public decimal? R825VremIst { get; set; }
        public decimal? R825ItogoIst { get; set; }
        public string R826Name { get; set; }
        public string R826StrKod { get; set; }
        public string R826KbkIst { get; set; }
        public string R826TypeKbk { get; set; }
        public decimal? R826BIst { get; set; }
        public decimal? R826VremIst { get; set; }
        public decimal? R826ItogoIst { get; set; }
        public string KasName { get; set; }
        public string KasStrKod { get; set; }
        public string KasKbkRash { get; set; }
        public string KasTypeKbk { get; set; }
        public decimal? KasBRash { get; set; }
        public decimal? KasVremRash { get; set; }
        public decimal? KasItogoRash { get; set; }
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
        public string PrizSo { get; set; }
        public string Z1 { get; set; }
        public string Z2 { get; set; }

        public virtual ICollection<FsT010151List> FsT010151List { get; set; }
        public virtual ICollection<FsT020151List> FsT020151List { get; set; }
        public virtual ICollection<FsT520151List> FsT520151List { get; set; }
        public virtual ICollection<FsT620151List> FsT620151List { get; set; }
        public virtual ICollection<FsT710151List> FsT710151List { get; set; }
        public virtual ICollection<FsT720151List> FsT720151List { get; set; }
    }
}
