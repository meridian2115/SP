using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class DcArpReport0531342
    {
        public DcArpReport0531342()
        {
            FsAaR1010List = new HashSet<FsAaR1010List>();
            FsAbR1200List = new HashSet<FsAbR1200List>();
            FsAcR3520List = new HashSet<FsAcR3520List>();
            FsAcR3825List = new HashSet<FsAcR3825List>();
            FsAcR3826List = new HashSet<FsAcR3826List>();
        }

        public decimal Docid { get; set; }
        public decimal? Version { get; set; }
        public string Ord { get; set; }
        public string PfnPfnLeader { get; set; }
        public string PfnPfnChiefAcc { get; set; }
        public string PfnPfnLeaderOfFes { get; set; }
        public string PfnPfnPostLeader { get; set; }
        public string PfnPfnPostChiefAcc { get; set; }
        public string PfnPfnPostLeaderOf { get; set; }
        public string PfnPfnExecutor { get; set; }
        public string PfnPfnPostExecutor { get; set; }
        public string PfnPfnPhone { get; set; }
        public string PfnTelephone { get; set; }
        public string System { get; set; }
        public string System1 { get; set; }
        public decimal? AaC6R010 { get; set; }
        public decimal? AaC7R010 { get; set; }
        public decimal? AaC8R010 { get; set; }
        public decimal? AaC9R010 { get; set; }
        public decimal? AbC6R200 { get; set; }
        public decimal? AbC7R200 { get; set; }
        public decimal? AbC8R200 { get; set; }
        public decimal? AbC9R200 { get; set; }
        public decimal? AcC6R520 { get; set; }
        public decimal? AcC7R520 { get; set; }
        public decimal? AcC8R520 { get; set; }
        public decimal? AcC9R520 { get; set; }
        public decimal? AcC6R800 { get; set; }
        public decimal? AcC7R800 { get; set; }
        public decimal? AcC8R800 { get; set; }
        public decimal? AcC9R800 { get; set; }
        public decimal? AcC6R825 { get; set; }
        public decimal? AcC7R825 { get; set; }
        public decimal? AcC8R825 { get; set; }
        public decimal? AcC9R825 { get; set; }
        public decimal? AcC6R826 { get; set; }
        public decimal? AcC7R826 { get; set; }
        public decimal? AcC8R826 { get; set; }
        public decimal? AcC9R826 { get; set; }
        public string Surrogat { get; set; }

        public virtual ICollection<FsAaR1010List> FsAaR1010List { get; set; }
        public virtual ICollection<FsAbR1200List> FsAbR1200List { get; set; }
        public virtual ICollection<FsAcR3520List> FsAcR3520List { get; set; }
        public virtual ICollection<FsAcR3825List> FsAcR3825List { get; set; }
        public virtual ICollection<FsAcR3826List> FsAcR3826List { get; set; }
    }
}
