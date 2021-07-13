using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class FsRegistresList
    {
        public decimal? Docid { get; set; }
        public decimal? Tablerownum { get; set; }
        public decimal Fieldsetid { get; set; }
        public string RfCodeForm { get; set; }
        public string RfOkudForm { get; set; }
        public string RfNameForm { get; set; }
        public string RfCd { get; set; }
        public string RfArcd { get; set; }
        public string RfNmcd { get; set; }
        public string RfForm { get; set; }
        public DateTime? RfStartDate { get; set; }
        public DateTime? RfEndDate { get; set; }
        public string Codef { get; set; }
        public string Nmbr { get; set; }
        public bool? Checkimport { get; set; }
        public string Arall { get; set; }
        public bool? FlagSubmit { get; set; }
        public string GlavaBk { get; set; }
        public bool? RedSvodForm { get; set; }
        public string RegisterName { get; set; }

        public virtual DcArpFahSets Doc { get; set; }
    }
}
