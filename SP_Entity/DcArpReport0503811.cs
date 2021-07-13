using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class DcArpReport0503811
    {
        public DcArpReport0503811()
        {
            FsT10503811List = new HashSet<FsT10503811List>();
            FsT20503811List = new HashSet<FsT20503811List>();
            FsT30503811List = new HashSet<FsT30503811List>();
        }

        public decimal Docid { get; set; }
        public decimal? Version { get; set; }
        public string Ord { get; set; }
        public string SePfnLeader { get; set; }
        public string SePfnChiefAcc { get; set; }
        public string SePfnLeaderOfFes { get; set; }
        public string SePfnPostLeader { get; set; }
        public string SePfnPostChiefAcc { get; set; }
        public string SePfnPostLeaderOf { get; set; }
        public string SePfnExecutor { get; set; }
        public string SePfnPostExecutor { get; set; }
        public string SePfnPhone { get; set; }
        public string Telephone { get; set; }
        public decimal? C8R01 { get; set; }
        public decimal? C7R02 { get; set; }
        public decimal? C8R02 { get; set; }
        public decimal? C9R02 { get; set; }
        public decimal? C10R02 { get; set; }
        public decimal? C11R02 { get; set; }
        public decimal? C8R03 { get; set; }
        public string Typesved { get; set; }
        public string Typeotch { get; set; }

        public virtual ICollection<FsT10503811List> FsT10503811List { get; set; }
        public virtual ICollection<FsT20503811List> FsT20503811List { get; set; }
        public virtual ICollection<FsT30503811List> FsT30503811List { get; set; }
    }
}
