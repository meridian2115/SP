using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class FsBaBa721List
    {
        public decimal Fieldsetid { get; set; }
        public decimal? Tablerownum { get; set; }
        public decimal? Docid { get; set; }
        public string Numbrow { get; set; }
        public string Signkbk { get; set; }
        public string Kbk { get; set; }
        public string Grbscode { get; set; }
        public string BdcodeSection { get; set; }
        public string BdcodeSubsection { get; set; }
        public string BdcodeTarget { get; set; }
        public string BdcodeExp { get; set; }
        public string Fkr { get; set; }
        public string Note { get; set; }
        public decimal? SyYear { get; set; }
        public decimal? SyYear1 { get; set; }
        public decimal? SyYear2 { get; set; }
        public string Circtechsign { get; set; }
        public string Personalaccountgrbs { get; set; }
        public string Fullkbktype { get; set; }
        public string Secrecy { get; set; }

        public virtual DcDbdTreasuryNotice Doc { get; set; }
    }
}
