using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class DcReport0503124
    {
        public DcReport0503124()
        {
            FsBcConsumpt124List = new HashSet<FsBcConsumpt124List>();
            FsBrRevenue124List = new HashSet<FsBrRevenue124List>();
            FsSfDecrease124List = new HashSet<FsSfDecrease124List>();
            FsSfDomestic124List = new HashSet<FsSfDomestic124List>();
            FsSfExternal124List = new HashSet<FsSfExternal124List>();
            FsSfIncrease124List = new HashSet<FsSfIncrease124List>();
        }

        public decimal Docid { get; set; }
        public decimal? Version { get; set; }
        public DateTime? DateOfSigning { get; set; }
        public string InstitutionCode { get; set; }
        public string PeriodType { get; set; }
        public string SubjReportCode { get; set; }
        public string ErNameOfEntity { get; set; }
        public string ErCodeOfEntity { get; set; }
        public string ErOkpo { get; set; }
        public string ErOktmo { get; set; }
        public string ErGlavaBk { get; set; }
        public string ErSubotch { get; set; }
        public string ErInn { get; set; }
        public string ErCdofentalt { get; set; }
        public string ErPrcdofent { get; set; }
        public string ErPrnmofent { get; set; }
        public string PfnLeader { get; set; }
        public string PfnChiefAcc { get; set; }
        public string PfnLeaderOfFes { get; set; }
        public string PfnPostLeader { get; set; }
        public string PfnPostChiefAcc { get; set; }
        public string PfnPostLeaderOf { get; set; }
        public string PfnExecutor { get; set; }
        public string PfnPostExecutor { get; set; }
        public string PfnPhone { get; set; }
        public decimal? BrG4S010 { get; set; }
        public decimal? BrG5S010 { get; set; }
        public decimal? BcG4S200 { get; set; }
        public decimal? BcG5S200 { get; set; }
        public decimal? BcG6S200 { get; set; }
        public decimal? BcG7S200 { get; set; }
        public decimal? BcG8S200 { get; set; }
        public decimal? BcG4S450 { get; set; }
        public decimal? BcG5S450 { get; set; }
        public decimal? SfG4S500 { get; set; }
        public decimal? SfG5S500 { get; set; }
        public decimal? SfG6S500 { get; set; }
        public decimal? SfG7S500 { get; set; }
        public decimal? SfG4S520 { get; set; }
        public decimal? SfG5S520 { get; set; }
        public decimal? SfG6S520 { get; set; }
        public decimal? SfG7S520 { get; set; }
        public decimal? SfG4S620 { get; set; }
        public decimal? SfG5S620 { get; set; }
        public decimal? SfG6S620 { get; set; }
        public decimal? SfG7S620 { get; set; }
        public decimal? SfG4S700 { get; set; }
        public decimal? SfG5S700 { get; set; }
        public decimal? SfG6S700 { get; set; }
        public decimal? SfG7S700 { get; set; }
        public decimal? SfG4S710 { get; set; }
        public decimal? SfG5S710 { get; set; }
        public decimal? SfG6S710 { get; set; }
        public decimal? SfG7S710 { get; set; }
        public decimal? SfG4S720 { get; set; }
        public decimal? SfG5S720 { get; set; }
        public decimal? SfG6S720 { get; set; }
        public decimal? SfG7S720 { get; set; }
        public decimal? SfG5S800 { get; set; }
        public decimal? SfG6S800 { get; set; }
        public decimal? SfG5S823 { get; set; }
        public decimal? SfG6S823 { get; set; }
        public decimal? SfG5S824 { get; set; }
        public decimal? SfG6S824 { get; set; }
        public decimal? SfG7S800 { get; set; }
        public decimal? SfG7S823 { get; set; }
        public decimal? SfG7S824 { get; set; }
        public decimal? SfG4S800 { get; set; }
        public decimal? SfG4S823 { get; set; }
        public decimal? SfG4S824 { get; set; }
        public string Ord { get; set; }
        public string System { get; set; }
        public string System1 { get; set; }
        public string Telephone { get; set; }
        public string CodeTofk { get; set; }
        public string NameTofk { get; set; }

        public virtual ICollection<FsBcConsumpt124List> FsBcConsumpt124List { get; set; }
        public virtual ICollection<FsBrRevenue124List> FsBrRevenue124List { get; set; }
        public virtual ICollection<FsSfDecrease124List> FsSfDecrease124List { get; set; }
        public virtual ICollection<FsSfDomestic124List> FsSfDomestic124List { get; set; }
        public virtual ICollection<FsSfExternal124List> FsSfExternal124List { get; set; }
        public virtual ICollection<FsSfIncrease124List> FsSfIncrease124List { get; set; }
    }
}
