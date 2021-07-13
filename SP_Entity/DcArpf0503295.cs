using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class DcArpf0503295
    {
        public DcArpf0503295()
        {
            FsRfTab0503296aList = new HashSet<FsRfTab0503296aList>();
        }

        public decimal Docid { get; set; }
        public decimal? Version { get; set; }
        public string HrReptype { get; set; }
        public decimal? ImC3R010 { get; set; }
        public decimal? ImC4R010 { get; set; }
        public decimal? ImC5R010 { get; set; }
        public decimal? ImC6R010 { get; set; }
        public decimal? ImC7R010 { get; set; }
        public decimal? ImC8R010 { get; set; }
        public decimal? ImC3R011 { get; set; }
        public decimal? ImC4R011 { get; set; }
        public decimal? ImC5R011 { get; set; }
        public decimal? ImC6R011 { get; set; }
        public decimal? ImC7R011 { get; set; }
        public decimal? ImC8R011 { get; set; }
        public decimal? ImC3R020 { get; set; }
        public decimal? ImC4R020 { get; set; }
        public decimal? ImC5R020 { get; set; }
        public decimal? ImC6R020 { get; set; }
        public decimal? ImC7R020 { get; set; }
        public decimal? ImC8R020 { get; set; }
        public decimal? ImC3R021 { get; set; }
        public decimal? ImC4R021 { get; set; }
        public decimal? ImC5R021 { get; set; }
        public decimal? ImC6R021 { get; set; }
        public decimal? ImC7R021 { get; set; }
        public decimal? ImC8R021 { get; set; }
        public decimal? ImC3R030 { get; set; }
        public decimal? ImC4R030 { get; set; }
        public decimal? ImC5R030 { get; set; }
        public decimal? ImC6R030 { get; set; }
        public decimal? ImC7R030 { get; set; }
        public decimal? ImC8R030 { get; set; }
        public decimal? RfC2R2 { get; set; }
        public decimal? RfC3R2 { get; set; }
        public decimal? RfC3R3 { get; set; }
        public string SgnPfnLeader { get; set; }
        public string SgnPfnChiefAcc { get; set; }
        public string SgnPfnLeaderOfFes { get; set; }
        public string SgnPfnPostLeader { get; set; }
        public string SgnPfnPostChiefAcc { get; set; }
        public string SgnPfnPostLeaderOf { get; set; }
        public string SgnPfnExecutor { get; set; }
        public string SgnPfnPostExecutor { get; set; }
        public string SgnPfnPhone { get; set; }
        public string SgnCaExecutorPost { get; set; }
        public string SgnCaExecutor { get; set; }
        public string SgnCaExecutorTel { get; set; }
        public string Ord { get; set; }

        public virtual ICollection<FsRfTab0503296aList> FsRfTab0503296aList { get; set; }
    }
}
