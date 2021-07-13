using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class DcArpInfConEb
    {
        public DcArpInfConEb()
        {
            FsInfTabConEbList = new HashSet<FsInfTabConEbList>();
        }

        public decimal Docid { get; set; }
        public decimal? Version { get; set; }
        public string HrSignpost { get; set; }
        public string HrSignfio { get; set; }
        public string HrSignphone { get; set; }
        public string HrSignemail { get; set; }
        public string HrOrd { get; set; }
        public string HrSubotch { get; set; }
        public decimal? InfC4 { get; set; }
        public decimal? InfC5 { get; set; }
        public decimal? InfC8 { get; set; }
        public decimal? InfC9 { get; set; }
        public decimal? InfC10 { get; set; }
        public decimal? InfC11 { get; set; }
        public decimal? InfC12 { get; set; }
        public decimal? InfC13 { get; set; }
        public decimal? InfC14 { get; set; }
        public decimal? InfC15 { get; set; }
        public decimal? InfC16 { get; set; }
        public decimal? InfC17 { get; set; }
        public decimal? InfC18 { get; set; }
        public decimal? InfC19 { get; set; }
        public decimal? InfC20 { get; set; }
        public decimal? InfC21 { get; set; }
        public decimal? InfC22 { get; set; }
        public decimal? InfC23 { get; set; }
        public decimal? InfC24 { get; set; }
        public decimal? InfC25 { get; set; }
        public decimal? InfC26 { get; set; }
        public decimal? InfC27 { get; set; }
        public decimal? InfC29 { get; set; }
        public decimal? InfC30 { get; set; }

        public virtual ICollection<FsInfTabConEbList> FsInfTabConEbList { get; set; }
    }
}
