using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class HArpf0503296
    {
        public HArpf0503296()
        {
            HfsRfTab0503296aList = new HashSet<HfsRfTab0503296aList>();
        }

        public decimal Id { get; set; }
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
        public string SgnCaExecutorPost { get; set; }
        public string SgnCaExecutor { get; set; }
        public string SgnCaExecutorTel { get; set; }

        public virtual ICollection<HfsRfTab0503296aList> HfsRfTab0503296aList { get; set; }
    }
}
