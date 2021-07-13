using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class DwInfodtktnballBankLink
    {
        public decimal DocId { get; set; }
        public string PurposeU { get; set; }
        public string EdNoU { get; set; }
        public DateTime? EdDateU { get; set; }
        public decimal? SumU { get; set; }
        public string AccDocNoU { get; set; }
        public string PersonalPayerAccU { get; set; }
        public string PersonalPayeeAccU { get; set; }
        public decimal? PacIdPayeeU { get; set; }
        public DateTime? OpDayDateU { get; set; }
        public decimal? SumCurrencyU { get; set; }
    }
}
