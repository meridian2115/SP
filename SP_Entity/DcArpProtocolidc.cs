using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class DcArpProtocolidc
    {
        public DcArpProtocolidc()
        {
            FsTableErrorsListIdc = new HashSet<FsTableErrorsListIdc>();
        }

        public decimal Docid { get; set; }
        public decimal? Version { get; set; }
        public string Protocolnumber { get; set; }
        public string LkpformCd { get; set; }
        public string LkpformRcmd { get; set; }
        public string LkpsbjtrptgCd { get; set; }
        public string LkpsbjtrptgNm { get; set; }
        public string Lookupemployeescode { get; set; }
        public string Lookupemployeesname { get; set; }
        public DateTime? Formationdate { get; set; }
        public DateTime? Reportdate { get; set; }
        public string Indicatorsreport { get; set; }
        public string Idreportform { get; set; }
        public string Cdofentalt { get; set; }
        public string Periodtype { get; set; }

        public virtual ICollection<FsTableErrorsListIdc> FsTableErrorsListIdc { get; set; }
    }
}
