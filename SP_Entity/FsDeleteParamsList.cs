using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class FsDeleteParamsList
    {
        public decimal? Docid { get; set; }
        public decimal? Tablerownum { get; set; }
        public decimal Fieldsetid { get; set; }
        public string Npp { get; set; }
        public string Cd { get; set; }
        public string Name { get; set; }
        public string State { get; set; }
        public string Period { get; set; }
        public string Type { get; set; }
        public string CdTofk { get; set; }
        public string Days { get; set; }
        public string Systemname { get; set; }
        public string Systemstate { get; set; }

        public virtual DcArpFahDelete Doc { get; set; }
    }
}
