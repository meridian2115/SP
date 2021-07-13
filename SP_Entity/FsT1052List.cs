using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class FsT1052List
    {
        public FsT1052List()
        {
            FsT2052List = new HashSet<FsT2052List>();
        }

        public decimal? Docid { get; set; }
        public decimal? Tablerownum { get; set; }
        public decimal Fieldsetid { get; set; }
        public string C1T1 { get; set; }
        public string C2T1 { get; set; }
        public string C3T1 { get; set; }
        public decimal? C4T1 { get; set; }
        public decimal? C5T1 { get; set; }
        public decimal? C6T1 { get; set; }
        public decimal? C7T1 { get; set; }
        public decimal? C8T1 { get; set; }
        public decimal? C9T1 { get; set; }
        public decimal? C10T1 { get; set; }
        public decimal? C11T1 { get; set; }
        public string Counter { get; set; }

        public virtual DcArpReport0507052 Doc { get; set; }
        public virtual ICollection<FsT2052List> FsT2052List { get; set; }
    }
}
