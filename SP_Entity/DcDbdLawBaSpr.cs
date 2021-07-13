using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class DcDbdLawBaSpr
    {
        public DcDbdLawBaSpr()
        {
            FsFpFpIncList = new HashSet<FsFpFpIncList>();
            FsFpdFpDeltaList = new HashSet<FsFpdFpDeltaList>();
            FsGpGpIncList = new HashSet<FsGpGpIncList>();
            FsGpdGpDeltaList = new HashSet<FsGpdGpDeltaList>();
            FsRzpdRzprDeltaList = new HashSet<FsRzpdRzprDeltaList>();
            FsRzprRzprIncList = new HashSet<FsRzprRzprIncList>();
        }

        public decimal Docid { get; set; }
        public decimal? Version { get; set; }
        public DateTime? TtlYear { get; set; }
        public decimal? RzprC3S { get; set; }
        public decimal? RzprC4S { get; set; }
        public decimal? RzprC5S { get; set; }
        public decimal? RzprC6S { get; set; }
        public decimal? RzprC7S { get; set; }
        public decimal? RzprC8S { get; set; }
        public decimal? RzprC9S { get; set; }
        public decimal? RzprC10S { get; set; }
        public decimal? RzprC11S { get; set; }
        public decimal? RzprC12S { get; set; }
        public decimal? GpC3S { get; set; }
        public decimal? GpC4S { get; set; }
        public decimal? GpC5S { get; set; }
        public decimal? GpC6S { get; set; }
        public decimal? GpC7S { get; set; }
        public decimal? GpC8S { get; set; }
        public decimal? GpC9S { get; set; }
        public decimal? GpC10S { get; set; }
        public decimal? GpC11S { get; set; }
        public decimal? GpC12S { get; set; }
        public decimal? FpC3S { get; set; }
        public decimal? FpC4S { get; set; }
        public decimal? FpC5S { get; set; }
        public decimal? FpC6S { get; set; }
        public decimal? FpC7S { get; set; }
        public decimal? FpC8S { get; set; }
        public decimal? FpC9S { get; set; }
        public decimal? FpC10S { get; set; }
        public decimal? FpC11S { get; set; }
        public decimal? FpC12S { get; set; }
        public decimal? RzpdC3S { get; set; }
        public decimal? RzpdC4S { get; set; }
        public decimal? RzpdC5S { get; set; }
        public decimal? RzpdC6S { get; set; }
        public decimal? RzpdC7S { get; set; }
        public decimal? GpdC3S { get; set; }
        public decimal? GpdC4S { get; set; }
        public decimal? GpdC5S { get; set; }
        public decimal? GpdC6S { get; set; }
        public decimal? GpdC7S { get; set; }
        public decimal? FpdC3S { get; set; }
        public decimal? FpdC4S { get; set; }
        public decimal? FpdC5S { get; set; }
        public decimal? FpdC6S { get; set; }
        public decimal? FpdC7S { get; set; }
        public decimal? FpC3Sg { get; set; }
        public decimal? FpC4Sg { get; set; }
        public decimal? FpC5Sg { get; set; }
        public decimal? FpC6Sg { get; set; }
        public decimal? FpC7Sg { get; set; }
        public decimal? FpC8Sg { get; set; }
        public decimal? FpC9Sg { get; set; }
        public decimal? FpC10Sg { get; set; }
        public decimal? FpC11Sg { get; set; }
        public decimal? FpC12Sg { get; set; }
        public decimal? FpC3Sn { get; set; }
        public decimal? FpC4Sn { get; set; }
        public decimal? FpC5Sn { get; set; }
        public decimal? FpC6Sn { get; set; }
        public decimal? FpC7Sn { get; set; }
        public decimal? FpC8Sn { get; set; }
        public decimal? FpC9Sn { get; set; }
        public decimal? FpC10Sn { get; set; }
        public decimal? FpC11Sn { get; set; }
        public decimal? FpC12Sn { get; set; }
        public decimal? FpC3Sv { get; set; }
        public decimal? FpC4Sv { get; set; }
        public decimal? FpC5Sv { get; set; }
        public decimal? FpC6Sv { get; set; }
        public decimal? FpC7Sv { get; set; }
        public decimal? FpC8Sv { get; set; }
        public decimal? FpC9Sv { get; set; }
        public decimal? FpC10Sv { get; set; }
        public decimal? FpC11Sv { get; set; }
        public decimal? FpC12Sv { get; set; }
        public decimal? GpdC3Sg { get; set; }
        public decimal? GpdC4Sg { get; set; }
        public decimal? GpdC5Sg { get; set; }
        public decimal? GpdC6Sg { get; set; }
        public decimal? GpdC7Sg { get; set; }
        public decimal? GpdC3Sn { get; set; }
        public decimal? GpdC4Sn { get; set; }
        public decimal? GpdC5Sn { get; set; }
        public decimal? GpdC6Sn { get; set; }
        public decimal? GpdC7Sn { get; set; }
        public decimal? FpdC3Sg { get; set; }
        public decimal? FpdC4Sg { get; set; }
        public decimal? FpdC5Sg { get; set; }
        public decimal? FpdC6Sg { get; set; }
        public decimal? FpdC7Sg { get; set; }
        public decimal? FpdC3Sn { get; set; }
        public decimal? FpdC4Sn { get; set; }
        public decimal? FpdC5Sn { get; set; }
        public decimal? FpdC6Sn { get; set; }
        public decimal? FpdC7Sn { get; set; }
        public decimal? FpdC3Sv { get; set; }
        public decimal? FpdC4Sv { get; set; }
        public decimal? FpdC5Sv { get; set; }
        public decimal? FpdC6Sv { get; set; }
        public decimal? FpdC7Sv { get; set; }

        public virtual ICollection<FsFpFpIncList> FsFpFpIncList { get; set; }
        public virtual ICollection<FsFpdFpDeltaList> FsFpdFpDeltaList { get; set; }
        public virtual ICollection<FsGpGpIncList> FsGpGpIncList { get; set; }
        public virtual ICollection<FsGpdGpDeltaList> FsGpdGpDeltaList { get; set; }
        public virtual ICollection<FsRzpdRzprDeltaList> FsRzpdRzprDeltaList { get; set; }
        public virtual ICollection<FsRzprRzprIncList> FsRzprRzprIncList { get; set; }
    }
}
