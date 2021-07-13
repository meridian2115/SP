using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class FsAppofstrList
    {
        public decimal? Docid { get; set; }
        public decimal? Tablerownum { get; set; }
        public decimal Fieldsetid { get; set; }
        public string Numbrow3 { get; set; }
        public string KbkKbk { get; set; }
        public string KbkTargetcode { get; set; }
        public string KbkBktype { get; set; }
        public decimal? Amount { get; set; }
        public string Note { get; set; }
        public string SiCurrentyear3 { get; set; }
        public string BdcodeSection { get; set; }
        public string BdcodeSubsection { get; set; }
        public string BdcodeTarget { get; set; }
        public string BdcodeExp { get; set; }
        public string FffSegment2 { get; set; }
        public string FffAttribute1VTech { get; set; }
        public string FffIncludingFlag { get; set; }
        public string FffYear { get; set; }
        public decimal? FffAmount { get; set; }
        public decimal? FffBaseAmount { get; set; }
        public string FffUomCoef { get; set; }
        public decimal? FffAmountMbt { get; set; }
        public string FffPeriodsign { get; set; }
        public string Typekbk { get; set; }

        public virtual DcMscExpendableschedule Doc { get; set; }
    }
}
