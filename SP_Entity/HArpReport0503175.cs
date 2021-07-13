using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class HArpReport0503175
    {
        public HArpReport0503175()
        {
            HfsS1T1List = new HashSet<HfsS1T1List>();
            HfsS1T2List = new HashSet<HfsS1T2List>();
            HfsS2T1List = new HashSet<HfsS2T1List>();
            HfsS2T2List = new HashSet<HfsS2T2List>();
            HfsS3T1List = new HashSet<HfsS3T1List>();
            HfsS3T2List = new HashSet<HfsS3T2List>();
            HfsS4T1List = new HashSet<HfsS4T1List>();
            HfsS4T2List = new HashSet<HfsS4T2List>();
        }

        public decimal Id { get; set; }
        public decimal? S1Sum { get; set; }
        public decimal? S2Sum { get; set; }
        public decimal? S3Sum { get; set; }
        public decimal? S4Sum { get; set; }

        public virtual ICollection<HfsS1T1List> HfsS1T1List { get; set; }
        public virtual ICollection<HfsS1T2List> HfsS1T2List { get; set; }
        public virtual ICollection<HfsS2T1List> HfsS2T1List { get; set; }
        public virtual ICollection<HfsS2T2List> HfsS2T2List { get; set; }
        public virtual ICollection<HfsS3T1List> HfsS3T1List { get; set; }
        public virtual ICollection<HfsS3T2List> HfsS3T2List { get; set; }
        public virtual ICollection<HfsS4T1List> HfsS4T1List { get; set; }
        public virtual ICollection<HfsS4T2List> HfsS4T2List { get; set; }
    }
}
