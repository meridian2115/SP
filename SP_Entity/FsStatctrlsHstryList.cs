using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class FsStatctrlsHstryList
    {
        public decimal? Docid { get; set; }
        public decimal? Tablerownum { get; set; }
        public decimal Fieldsetid { get; set; }
        public DateTime? P1Datetimecontrol { get; set; }
        public string P1Controlexecuter { get; set; }
        public string P1Formstate { get; set; }
        public string P1Controltype { get; set; }
        public string P1Resultcontrol { get; set; }
        public string P1Protocol { get; set; }
        public string P1Guid { get; set; }
        public DateTime? P2Datetimecontrol { get; set; }
        public string P2Controlexecuter { get; set; }
        public string P2Formstate { get; set; }
        public string P2Controltype { get; set; }
        public string P2Resultcontrol { get; set; }
        public string P2Protocol { get; set; }
        public string P2Guid { get; set; }
        public DateTime? Datetimecontrol { get; set; }
        public string Controlexecuter { get; set; }
        public string Formstate { get; set; }
        public string Controltype { get; set; }
        public string Resultcontrol { get; set; }
        public string Protocol { get; set; }
        public string Guid { get; set; }

        public virtual DcMegatableform Doc { get; set; }
    }
}
