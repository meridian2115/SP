using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class DcArpFahIndpersacc
    {
        public DcArpFahIndpersacc()
        {
            FsLsindList = new HashSet<FsLsindList>();
        }

        public decimal Docid { get; set; }
        public decimal? Version { get; set; }
        public string Npp { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public string Upcode { get; set; }
        public string Note { get; set; }
        public DateTime? DataStartactive { get; set; }
        public DateTime? DataEndactive { get; set; }
        public string Codep { get; set; }
        public string Calc { get; set; }
        public string Formula { get; set; }
        public string Field1 { get; set; }
        public string Field2 { get; set; }
        public decimal? Multiplier1 { get; set; }
        public decimal? Multiplier2 { get; set; }
        public string Sign { get; set; }
        public string TypeParam { get; set; }
        public string Widthfieldname { get; set; }

        public virtual ICollection<FsLsindList> FsLsindList { get; set; }
    }
}
