using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class DcArpProtocolflk
    {
        public DcArpProtocolflk()
        {
            FsTableerrorsList1 = new HashSet<FsTableerrorsList1>();
        }

        public decimal Docid { get; set; }
        public decimal? Version { get; set; }
        public string Protocolnumber { get; set; }
        public DateTime? Reportdate { get; set; }
        public string Code { get; set; }
        public string Indicatorsreport { get; set; }
        public string Rcmd { get; set; }
        public string Cdalt { get; set; }
        public string Sbjrepname { get; set; }
        public DateTime? Formationdate { get; set; }
        public string Lookupemployeescode { get; set; }
        public string Lookupeployeesname { get; set; }
        public string Idreportform { get; set; }
        public string Cdofentalt { get; set; }
        public string Periodtype { get; set; }

        public virtual ICollection<FsTableerrorsList1> FsTableerrorsList1 { get; set; }
    }
}
