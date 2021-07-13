using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class DcArpReport0507021Fk
    {
        public DcArpReport0507021Fk()
        {
            FsBe1T2021fkList = new HashSet<FsBe1T2021fkList>();
            FsBeTabr2021fkList = new HashSet<FsBeTabr2021fkList>();
            FsBedTabr2021fkList = new HashSet<FsBedTabr2021fkList>();
            FsBr1T1021fkList = new HashSet<FsBr1T1021fkList>();
            FsBrTabr1021fkList = new HashSet<FsBrTabr1021fkList>();
            FsBrdTabr1021fkList = new HashSet<FsBrdTabr1021fkList>();
            FsSf1T3021fkList = new HashSet<FsSf1T3021fkList>();
            FsSfTabr3021fkList = new HashSet<FsSfTabr3021fkList>();
            FsSfdTabr3021fkList = new HashSet<FsSfdTabr3021fkList>();
        }

        public decimal Docid { get; set; }
        public decimal? Version { get; set; }
        public string Ord { get; set; }
        public string PrintPt { get; set; }
        public string PfnLeader { get; set; }
        public string PfnChiefAcc { get; set; }
        public string PfnLeaderOfFes { get; set; }
        public string PfnPostLeader { get; set; }
        public string PfnPostChiefAcc { get; set; }
        public string PfnPostLeaderOf { get; set; }
        public string PfnExecutor { get; set; }
        public string PfnPostExecutor { get; set; }
        public string PfnPhone { get; set; }
        public string BrC2R010 { get; set; }
        public decimal? BrC3R010 { get; set; }
        public decimal? BrC4R010 { get; set; }
        public decimal? BrC5R010 { get; set; }
        public decimal? BrC6R010 { get; set; }
        public decimal? BrC7R010 { get; set; }
        public string BrdC2R010 { get; set; }
        public decimal? BrdC3R010 { get; set; }
        public decimal? BrdC4R010 { get; set; }
        public decimal? BrdC5R010 { get; set; }
        public decimal? BrdC6R010 { get; set; }
        public decimal? BrdC7R010 { get; set; }
        public string BeC2R200 { get; set; }
        public decimal? BeC3R200 { get; set; }
        public decimal? BeC4R200 { get; set; }
        public decimal? BeC5R200 { get; set; }
        public decimal? BeC6R200 { get; set; }
        public decimal? BeC7R200 { get; set; }
        public string BedC2R200 { get; set; }
        public decimal? BedC3R200 { get; set; }
        public decimal? BedC4R200 { get; set; }
        public decimal? BedC5R200 { get; set; }
        public decimal? BedC6R200 { get; set; }
        public decimal? BedC7R200 { get; set; }
        public string SfC2500 { get; set; }
        public decimal? SfC3R500 { get; set; }
        public decimal? SfC4R500 { get; set; }
        public decimal? SfC5R500 { get; set; }
        public decimal? SfC6R500 { get; set; }
        public decimal? SfC7R500 { get; set; }
        public string SfdC2500 { get; set; }
        public decimal? SfdC3R500 { get; set; }
        public decimal? SfdC4R500 { get; set; }
        public decimal? SfdC5R500 { get; set; }
        public decimal? SfdC6R500 { get; set; }
        public decimal? SfdC7R500 { get; set; }
        public decimal? Test { get; set; }

        public virtual ICollection<FsBe1T2021fkList> FsBe1T2021fkList { get; set; }
        public virtual ICollection<FsBeTabr2021fkList> FsBeTabr2021fkList { get; set; }
        public virtual ICollection<FsBedTabr2021fkList> FsBedTabr2021fkList { get; set; }
        public virtual ICollection<FsBr1T1021fkList> FsBr1T1021fkList { get; set; }
        public virtual ICollection<FsBrTabr1021fkList> FsBrTabr1021fkList { get; set; }
        public virtual ICollection<FsBrdTabr1021fkList> FsBrdTabr1021fkList { get; set; }
        public virtual ICollection<FsSf1T3021fkList> FsSf1T3021fkList { get; set; }
        public virtual ICollection<FsSfTabr3021fkList> FsSfTabr3021fkList { get; set; }
        public virtual ICollection<FsSfdTabr3021fkList> FsSfdTabr3021fkList { get; set; }
    }
}
