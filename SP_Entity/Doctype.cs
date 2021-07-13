using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class Doctype
    {
        public Doctype()
        {
            AutosaveData = new HashSet<AutosaveData>();
        }

        public decimal Doctypeid { get; set; }
        public decimal? Version { get; set; }
        public string Systemname { get; set; }
        public string Name { get; set; }
        public decimal Docserviceid { get; set; }
        public bool? Visible { get; set; }
        public string Currentversion { get; set; }
        public bool? Dictionary { get; set; }
        public bool? JournalRequired { get; set; }
        public string CertKeyUsageOid { get; set; }
        public decimal Multisendrecipientscount { get; set; }
        public decimal? Parentdoctypeid { get; set; }
        public bool? Abstract { get; set; }
        public bool? Historyenable { get; set; }
        public string Lifecyclename { get; set; }

        public virtual ICollection<AutosaveData> AutosaveData { get; set; }
    }
}
