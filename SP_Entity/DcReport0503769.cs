using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class DcReport0503769
    {
        public DcReport0503769()
        {
            FsAnalyticalinfList = new HashSet<FsAnalyticalinfList>();
            FsMoveinfoList = new HashSet<FsMoveinfoList>();
            FsRevSItogiList = new HashSet<FsRevSItogiList>();
            FsRevenueItogiList = new HashSet<FsRevenueItogiList>();
            FsRevenueList = new HashSet<FsRevenueList>();
            FsSintItogi1List = new HashSet<FsSintItogi1List>();
            FsT40140769List = new HashSet<FsT40140769List>();
            FsT40160769List = new HashSet<FsT40160769List>();
            FsTotalmoveinfoList = new HashSet<FsTotalmoveinfoList>();
        }

        public decimal Docid { get; set; }
        public decimal? Version { get; set; }
        public string Nameseparatedivision { get; set; }
        public string Codeseparatedivision { get; set; }
        public string Namefounder { get; set; }
        public string Codefounder { get; set; }
        public string Namebodyactingfounder { get; set; }
        public string Codebodyactingfounder { get; set; }
        public string Surrogat { get; set; }
        public bool? SubDiv { get; set; }
        public string PfnPfnLeader { get; set; }
        public string PfnPfnChiefAcc { get; set; }
        public string PfnPfnLeaderOfFes { get; set; }
        public string PfnPfnPostLeader { get; set; }
        public string PfnPfnPostChiefAcc { get; set; }
        public string PfnPfnPostLeaderOf { get; set; }
        public string PfnPfnExecutor { get; set; }
        public string PfnPfnPostExecutor { get; set; }
        public string PfnPfnPhone { get; set; }
        public string VidZadolzhnosti { get; set; }
        public string Ord { get; set; }
        public decimal? ItogoC2R01030 { get; set; }
        public decimal? ItogoC2R01031 { get; set; }
        public decimal? ItogoC2R01032 { get; set; }
        public decimal? ItogoC3R01030 { get; set; }
        public decimal? ItogoC3R01031 { get; set; }
        public decimal? ItogoC3R01032 { get; set; }
        public decimal? ItogoC4R01030 { get; set; }
        public decimal? ItogoC4R01031 { get; set; }
        public decimal? ItogoC4R01032 { get; set; }
        public decimal? ItogoC5R01030 { get; set; }
        public decimal? ItogoC5R01031 { get; set; }
        public decimal? ItogoC5R01032 { get; set; }
        public decimal? ItogoC6R01030 { get; set; }
        public decimal? ItogoC7R01030 { get; set; }
        public decimal? ItogoC8R01030 { get; set; }
        public decimal? ItogoC9R01030 { get; set; }
        public decimal? ItogoC10R01030 { get; set; }
        public decimal? ItogoC11R01030 { get; set; }
        public decimal? ItogoC12R01030 { get; set; }
        public decimal? ItogoC13R01030 { get; set; }
        public decimal? ItogoC14R01030 { get; set; }
        public string TmiC1R0303 { get; set; }
        public string TmiC2R0303 { get; set; }
        public decimal? TmiC3R0303 { get; set; }
        public decimal? TmiC4R0303 { get; set; }
        public decimal? TmiC5R0303 { get; set; }
        public decimal? AidC3R03010 { get; set; }
        public decimal? AidC4R03010 { get; set; }
        public decimal? AidC5R03010 { get; set; }
        public decimal? AidC3R03011 { get; set; }
        public decimal? AidC4R03011 { get; set; }
        public decimal? AidC5R03011 { get; set; }
        public decimal? AidC3R03012 { get; set; }
        public decimal? AidC4R03012 { get; set; }
        public decimal? AidC5R03012 { get; set; }
        public decimal? AidC3R03013 { get; set; }
        public decimal? AidC4R03013 { get; set; }
        public decimal? AidC5R03013 { get; set; }
        public decimal? AidC3R03014 { get; set; }
        public decimal? AidC4R03014 { get; set; }
        public decimal? AidC5R03014 { get; set; }
        public decimal? AidC3R03015 { get; set; }
        public decimal? AidC4R03015 { get; set; }
        public decimal? AidC5R03015 { get; set; }
        public decimal? AidC3R03016 { get; set; }
        public decimal? AidC4R03016 { get; set; }
        public decimal? AidC5R03016 { get; set; }
        public decimal? AidC3R03020 { get; set; }
        public decimal? AidC4R03020 { get; set; }
        public decimal? AidC5R03020 { get; set; }
        public decimal? AidC3R03021 { get; set; }
        public decimal? AidC4R03021 { get; set; }
        public decimal? AidC5R03021 { get; set; }
        public decimal? AidC3R03022 { get; set; }
        public decimal? AidC4R03022 { get; set; }
        public decimal? AidC5R03022 { get; set; }
        public decimal? AidC3R03023 { get; set; }
        public decimal? AidC4R03023 { get; set; }
        public decimal? AidC5R03023 { get; set; }
        public decimal? AidC3R03024 { get; set; }
        public decimal? AidC4R03024 { get; set; }
        public decimal? AidC5R03024 { get; set; }
        public decimal? AidC3R03025 { get; set; }
        public decimal? AidC4R03025 { get; set; }
        public decimal? AidC5R03025 { get; set; }
        public decimal? AidC3R03026 { get; set; }
        public decimal? AidC4R03026 { get; set; }
        public decimal? AidC5R03026 { get; set; }
        public decimal? AidC3R03030 { get; set; }
        public decimal? AidC4R03030 { get; set; }
        public decimal? AidC5R03030 { get; set; }
        public decimal? AidC3R03031 { get; set; }
        public decimal? AidC4R03031 { get; set; }
        public decimal? AidC5R03031 { get; set; }
        public decimal? AidC3R03040 { get; set; }
        public decimal? AidC4R03040 { get; set; }
        public decimal? AidC5R03040 { get; set; }
        public decimal? AidC3R03041 { get; set; }
        public decimal? AidC4R03041 { get; set; }
        public decimal? AidC5R03041 { get; set; }
        public decimal? AidC3R03050 { get; set; }
        public decimal? AidC4R03050 { get; set; }
        public decimal? AidC5R03050 { get; set; }
        public decimal? AidC3R03051 { get; set; }
        public decimal? AidC4R03051 { get; set; }
        public decimal? AidC5R03051 { get; set; }
        public decimal? AidC3R03060 { get; set; }
        public decimal? AidC4R03060 { get; set; }
        public decimal? AidC5R03060 { get; set; }
        public decimal? AidC3R03061 { get; set; }
        public decimal? AidC4R03061 { get; set; }
        public decimal? AidC5R03061 { get; set; }
        public decimal? AidC3R03062 { get; set; }
        public decimal? AidC4R03062 { get; set; }
        public decimal? AidC5R03062 { get; set; }
        public decimal? AidC3R03063 { get; set; }
        public decimal? AidC4R03063 { get; set; }
        public decimal? AidC5R03063 { get; set; }
        public decimal? AidC3R03064 { get; set; }
        public decimal? AidC4R03064 { get; set; }
        public decimal? AidC5R03064 { get; set; }
        public decimal? AidC3R03065 { get; set; }
        public decimal? AidC4R03065 { get; set; }
        public decimal? AidC5R03065 { get; set; }
        public decimal? AidC3R03066 { get; set; }
        public decimal? AidC4R03066 { get; set; }
        public decimal? AidC5R03066 { get; set; }
        public DateTime? Dateminusday { get; set; }
        public DateTime? Dateminusyear { get; set; }
        public decimal? Itogo40140C2R3 { get; set; }
        public decimal? Itogo40140C3R3 { get; set; }
        public decimal? Itogo40140C4R3 { get; set; }
        public decimal? Itogo40140C5R3 { get; set; }
        public decimal? Itogo40140C6R3 { get; set; }
        public decimal? Itogo40140C7R3 { get; set; }
        public decimal? Itogo40140C8R3 { get; set; }
        public decimal? Itogo40140C9R3 { get; set; }
        public decimal? Itogo40140C10R3 { get; set; }
        public decimal? Itogo40140C11R3 { get; set; }
        public decimal? Itogo40140C12R3 { get; set; }
        public decimal? Itogo40140C13R3 { get; set; }
        public decimal? Itogo40140C14R3 { get; set; }
        public decimal? Itogo40160C2R4 { get; set; }
        public decimal? Itogo40160C3R4 { get; set; }
        public decimal? Itogo40160C4R4 { get; set; }
        public decimal? Itogo40160C5R4 { get; set; }
        public decimal? Itogo40160C6R4 { get; set; }
        public decimal? Itogo40160C7R4 { get; set; }
        public decimal? Itogo40160C8R4 { get; set; }
        public decimal? Itogo40160C9R4 { get; set; }
        public decimal? Itogo40160C10R4 { get; set; }
        public decimal? Itogo40160C11R4 { get; set; }
        public decimal? Itogo40160C12R4 { get; set; }
        public decimal? Itogo40160C13R4 { get; set; }
        public decimal? Itogo40160C14R4 { get; set; }
        public decimal? Year { get; set; }

        public virtual ICollection<FsAnalyticalinfList> FsAnalyticalinfList { get; set; }
        public virtual ICollection<FsMoveinfoList> FsMoveinfoList { get; set; }
        public virtual ICollection<FsRevSItogiList> FsRevSItogiList { get; set; }
        public virtual ICollection<FsRevenueItogiList> FsRevenueItogiList { get; set; }
        public virtual ICollection<FsRevenueList> FsRevenueList { get; set; }
        public virtual ICollection<FsSintItogi1List> FsSintItogi1List { get; set; }
        public virtual ICollection<FsT40140769List> FsT40140769List { get; set; }
        public virtual ICollection<FsT40160769List> FsT40160769List { get; set; }
        public virtual ICollection<FsTotalmoveinfoList> FsTotalmoveinfoList { get; set; }
    }
}
