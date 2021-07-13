using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class DcArpDataAsfk
    {
        public DcArpDataAsfk()
        {
            FsTDataAsfkList = new HashSet<FsTDataAsfkList>();
        }

        public decimal Docid { get; set; }
        public decimal? Version { get; set; }
        public string Tofk { get; set; }
        public DateTime? DataStartactive { get; set; }
        public DateTime? DataEndactive { get; set; }
        public string Book { get; set; }
        public string BookCd { get; set; }
        public string Login { get; set; }
        public string Instcd { get; set; }

        public virtual ICollection<FsTDataAsfkList> FsTDataAsfkList { get; set; }
    }
}
