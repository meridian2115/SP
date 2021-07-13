using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class DcArpReport0503364
    {
        public DcArpReport0503364()
        {
            FsBeExp364List = new HashSet<FsBeExp364List>();
            FsBrRev364List = new HashSet<FsBrRev364List>();
            FsSfDom364List = new HashSet<FsSfDom364List>();
            FsSfExt364List = new HashSet<FsSfExt364List>();
        }

        public decimal Docid { get; set; }
        public decimal? Version { get; set; }
        public decimal? BrC3R010 { get; set; }
        public decimal? BrC4R010 { get; set; }
        public decimal? BrC5R010 { get; set; }
        public decimal? BrC6R010 { get; set; }
        public decimal? BrC7R010 { get; set; }
        public string BrC8R010 { get; set; }
        public decimal? BeC3R200 { get; set; }
        public decimal? BeC4R200 { get; set; }
        public decimal? BeC5R200 { get; set; }
        public decimal? BeC6R200 { get; set; }
        public decimal? BeC7R200 { get; set; }
        public string BeC8R200 { get; set; }
        public decimal? BeOutcomeC3R450 { get; set; }
        public decimal? BeOutcomeC4R450 { get; set; }
        public decimal? BeOutcomeC5R450 { get; set; }
        public decimal? SfC3R500 { get; set; }
        public decimal? SfC4R500 { get; set; }
        public decimal? SfC5R500 { get; set; }
        public decimal? SfC6R500 { get; set; }
        public decimal? SfC7R500 { get; set; }
        public string SfC8R500 { get; set; }
        public decimal? SfC3R520 { get; set; }
        public decimal? SfC4R520 { get; set; }
        public decimal? SfC5R520 { get; set; }
        public decimal? SfC6R520 { get; set; }
        public decimal? SfC7R520 { get; set; }
        public string SfC8R520 { get; set; }
        public decimal? SfC3R620 { get; set; }
        public decimal? SfC4R620 { get; set; }
        public decimal? SfC5R620 { get; set; }
        public decimal? SfC6R620 { get; set; }
        public decimal? SfC7R620 { get; set; }
        public string SfC8R620 { get; set; }
        public string SignaLeader { get; set; }
        public string SignaChiefAcc { get; set; }
        public string SignaLeaderOfFes { get; set; }
        public string SignaPostLeader { get; set; }
        public string SignaPostChiefAcc { get; set; }
        public string SignaPostLeaderOf { get; set; }
        public string SignaExecutor { get; set; }
        public string SignaPostExecutor { get; set; }
        public string SignaPhone { get; set; }
        public string Surrogat { get; set; }
        public string Ord { get; set; }
        public string Namtip { get; set; }
        public string Subotch { get; set; }
        public DateTime? VData { get; set; }
        public string VPeriodName { get; set; }
        public DateTime? Year { get; set; }

        public virtual ICollection<FsBeExp364List> FsBeExp364List { get; set; }
        public virtual ICollection<FsBrRev364List> FsBrRev364List { get; set; }
        public virtual ICollection<FsSfDom364List> FsSfDom364List { get; set; }
        public virtual ICollection<FsSfExt364List> FsSfExt364List { get; set; }
    }
}
