using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class HReport0503175
    {
        public HReport0503175()
        {
            HfsS1T11175List = new HashSet<HfsS1T11175List>();
            HfsS1T21175List = new HashSet<HfsS1T21175List>();
            HfsS2T12175List = new HashSet<HfsS2T12175List>();
            HfsS2T22175List = new HashSet<HfsS2T22175List>();
            HfsS3T13175List = new HashSet<HfsS3T13175List>();
            HfsS3T23175List = new HashSet<HfsS3T23175List>();
            HfsS4T14175List = new HashSet<HfsS4T14175List>();
            HfsS4T24175List = new HashSet<HfsS4T24175List>();
        }

        public decimal Id { get; set; }
        public decimal? S1SumT1 { get; set; }
        public decimal? S1SumT2 { get; set; }
        public decimal? S1SumS1 { get; set; }
        public decimal? S2SumT1 { get; set; }
        public decimal? S2SumT2 { get; set; }
        public decimal? S2SumS2 { get; set; }
        public decimal? S3SumS3 { get; set; }
        public decimal? S4SumS4 { get; set; }

        public virtual ICollection<HfsS1T11175List> HfsS1T11175List { get; set; }
        public virtual ICollection<HfsS1T21175List> HfsS1T21175List { get; set; }
        public virtual ICollection<HfsS2T12175List> HfsS2T12175List { get; set; }
        public virtual ICollection<HfsS2T22175List> HfsS2T22175List { get; set; }
        public virtual ICollection<HfsS3T13175List> HfsS3T13175List { get; set; }
        public virtual ICollection<HfsS3T23175List> HfsS3T23175List { get; set; }
        public virtual ICollection<HfsS4T14175List> HfsS4T14175List { get; set; }
        public virtual ICollection<HfsS4T24175List> HfsS4T24175List { get; set; }
    }
}
