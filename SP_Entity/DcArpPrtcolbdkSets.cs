using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class DcArpPrtcolbdkSets
    {
        public DcArpPrtcolbdkSets()
        {
            FsTableErrorsSetsList = new HashSet<FsTableErrorsSetsList>();
        }

        public decimal Docid { get; set; }
        public decimal? Version { get; set; }
        public string Protocolnumber { get; set; }
        public string LkpsetsrprtgCd { get; set; }
        public string LkpsetsrprtgNm { get; set; }
        public string LkpsbjtrptgCd { get; set; }
        public string Indicatorsreport { get; set; }
        public string LkpsbjtrptgNm { get; set; }
        public string Lookupemployeescode { get; set; }
        public string Lookupemployeesname { get; set; }
        public DateTime? Formationdate { get; set; }
        public DateTime? Reportdate { get; set; }

        public virtual ICollection<FsTableErrorsSetsList> FsTableErrorsSetsList { get; set; }
    }
}
