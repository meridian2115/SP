using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class DcArpFahDelete
    {
        public DcArpFahDelete()
        {
            FsDeleteParamsList = new HashSet<FsDeleteParamsList>();
        }

        public decimal Docid { get; set; }
        public decimal? Version { get; set; }
        public string Dayz { get; set; }
        public string Name { get; set; }
        public string Cd { get; set; }
        public string CdTofk { get; set; }
        public string NameTofk { get; set; }
        public DateTime? Startactive { get; set; }
        public DateTime? Endactive { get; set; }
        public string Note { get; set; }
        public string TInstcd { get; set; }

        public virtual ICollection<FsDeleteParamsList> FsDeleteParamsList { get; set; }
    }
}
