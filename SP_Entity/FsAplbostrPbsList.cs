using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class FsAplbostrPbsList
    {
        public decimal Fieldsetid { get; set; }
        public decimal? Tablerownum { get; set; }
        public decimal? Docid { get; set; }
        public string Numbrow2 { get; set; }
        public string KbklKbk { get; set; }
        public string KbklTargetcode { get; set; }
        public decimal? KbklAmountcurryear { get; set; }
        public decimal? KbklAmountfirstyear { get; set; }
        public decimal? KbklAmountsecondyear { get; set; }
        public string Notelbo { get; set; }
        public string SiCurrentyear2 { get; set; }
        public string SiFirstplanyear2 { get; set; }
        public string SiSecondplanyear2 { get; set; }
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
        public string Signnsls { get; set; }
        public string Faipcode { get; set; }
        public string Faipattrcode { get; set; }
        public bool? Signfunds { get; set; }
        public string Secrecy { get; set; }

        public virtual DcMscExpendableschdPbs Doc { get; set; }
    }
}
