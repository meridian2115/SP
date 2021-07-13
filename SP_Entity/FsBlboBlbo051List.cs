using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class FsBlboBlbo051List
    {
        public decimal Fieldsetid { get; set; }
        public decimal? Tablerownum { get; set; }
        public decimal? Docid { get; set; }
        public string Numbrow { get; set; }
        public decimal? Numbrow1 { get; set; }
        public string Signkbk { get; set; }
        public string Kbk { get; set; }
        public string Objcode { get; set; }
        public string Personalaccountgrbs { get; set; }
        public string Fullkbktype { get; set; }
        public string Techsign { get; set; }
        public decimal? SyYear { get; set; }
        public decimal? SyYear1 { get; set; }
        public decimal? SyYear2 { get; set; }
        public decimal? SytechYear { get; set; }
        public decimal? SytechYear1 { get; set; }
        public decimal? SytechYear2 { get; set; }
        public string Grbscode { get; set; }
        public string BdcodeSection { get; set; }
        public string BdcodeSubsection { get; set; }
        public string BdcodeTarget { get; set; }
        public string BdcodeExp { get; set; }
        public string Specinstcode { get; set; }
        public string Guidku { get; set; }
        public string Circtechsign { get; set; }
        public string Typeku { get; set; }
        public decimal? SyUYear { get; set; }
        public decimal? SyUYear1 { get; set; }
        public decimal? SyUYear2 { get; set; }
        public decimal? SytechUYear { get; set; }
        public decimal? SytechUYear1 { get; set; }
        public decimal? SytechUYear2 { get; set; }
        public string Numbku { get; set; }
        public DateTime? Dateku { get; set; }

        public virtual DcDbdSumbudlistlbo Doc { get; set; }
    }
}
