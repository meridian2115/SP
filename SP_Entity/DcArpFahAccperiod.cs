using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class DcArpFahAccperiod
    {
        public DcArpFahAccperiod()
        {
            FsPrdList = new HashSet<FsPrdList>();
        }

        public decimal Docid { get; set; }
        public decimal? Version { get; set; }
        public string Book { get; set; }
        public string Year { get; set; }
        public string Period { get; set; }
        public string Login { get; set; }
        public string ErrorProc { get; set; }

        public virtual ICollection<FsPrdList> FsPrdList { get; set; }
    }
}
