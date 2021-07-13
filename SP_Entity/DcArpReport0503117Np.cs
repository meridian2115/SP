using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class DcArpReport0503117Np
    {
        public DcArpReport0503117Np()
        {
            FsBeR2117np200List = new HashSet<FsBeR2117np200List>();
        }

        public decimal Docid { get; set; }
        public decimal? Version { get; set; }
        public string Ord { get; set; }
        public decimal? BeC4R200 { get; set; }
        public decimal? BeC5R200 { get; set; }
        public decimal? BeC6R200 { get; set; }
        public decimal? BeC4R450 { get; set; }
        public decimal? BeC5R450 { get; set; }
        public decimal? BeC6R450 { get; set; }
        public string Surrogat { get; set; }
        public string Namtip { get; set; }
        public DateTime? Dataarp7238 { get; set; }
        public string SePfnLeader { get; set; }
        public string SePfnChiefAcc { get; set; }
        public string SePfnLeaderOfFes { get; set; }
        public string SePfnPostLeader { get; set; }
        public string SePfnPostChiefAcc { get; set; }
        public string SePfnPostLeaderOf { get; set; }
        public string SePfnExecutor { get; set; }
        public string SePfnPostExecutor { get; set; }
        public string SePfnPhone { get; set; }
        public string Guid117 { get; set; }
        public string Telephone { get; set; }
        public string Mncplnm { get; set; }
        public string Codeoktmomo { get; set; }
        public decimal? Year { get; set; }
        public decimal? Yeararp7238 { get; set; }
        public decimal? Year2017 { get; set; }

        public virtual ICollection<FsBeR2117np200List> FsBeR2117np200List { get; set; }
    }
}
