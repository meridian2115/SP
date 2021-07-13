using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class FsApbastrPbsList
    {
        public decimal Fieldsetid { get; set; }
        public decimal? Tablerownum { get; set; }
        public decimal? Docid { get; set; }
        public string Numbrow1 { get; set; }
        public string KbkbKbk { get; set; }
        public string KbkbTargetcode { get; set; }
        public decimal? KbkbAmountcurryear { get; set; }
        public decimal? KbkbAmountfirstyear { get; set; }
        public decimal? KbkbAmountsecondyear { get; set; }
        public string Noteba { get; set; }
        public string SiCurrentyear1 { get; set; }
        public string SiFirstplanyear1 { get; set; }
        public string SiSecondplanyear1 { get; set; }
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
        public string Typekbk { get; set; }
        public string Signnsi { get; set; }
        public string Guidinfokbkrashod { get; set; }
        public string Secrecy { get; set; }

        public virtual DcMscExpendableschdPbs Doc { get; set; }
    }
}
