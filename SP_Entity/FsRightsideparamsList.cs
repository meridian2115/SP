using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class FsRightsideparamsList
    {
        public decimal? Docid { get; set; }
        public decimal? Tablerownum { get; set; }
        public decimal Fieldsetid { get; set; }
        public string Name { get; set; }
        public string Paramtype { get; set; }
        public bool? Oppositesign { get; set; }
        public string Docfield { get; set; }
        public string Doctable { get; set; }
        public string Tablecolumn { get; set; }
        public string Usrfld { get; set; }
        public string Usrtblfld { get; set; }
        public string Section { get; set; }
        public string Colmn { get; set; }
        public string Linenumber { get; set; }
        public string Contentrow { get; set; }
        public string Operat { get; set; }
        public string Codereportform { get; set; }
        public string Namereportform { get; set; }
        public string Systemnamereportform { get; set; }
        public string Acctgcode { get; set; }
        public string AiCode { get; set; }
        public string AiName { get; set; }
        public string ParamtypeTemp { get; set; }
        public string DeviationDate { get; set; }
        public string Numbercolum { get; set; }
        public bool? Absolute { get; set; }
        public string Namemask { get; set; }
        public decimal? Substringbeg { get; set; }
        public decimal? Substringlength { get; set; }
        public string Substringcontent { get; set; }
        public bool? Mask { get; set; }
        public bool? Substring { get; set; }
        public string Typesubj { get; set; }
        public string Paramtypeforflk { get; set; }
        public bool? PrDaily { get; set; }
        public bool? PrMonthly { get; set; }
        public bool? PrQuarterly { get; set; }
        public bool? PrHalfyearly { get; set; }
        public bool? PrYearly { get; set; }
        public bool? PrOndate { get; set; }
        public DateTime? PrRnddate { get; set; }
        public bool? PrOnperiod { get; set; }
        public bool? PrWeek { get; set; }
        public bool? PrReorg { get; set; }
        public string Oktmocode { get; set; }
        public string Namebudget { get; set; }
        public string Codebudg { get; set; }
        public string Reporttype { get; set; }
        public string Acctgcodeoperator { get; set; }
        public string Doctablesc { get; set; }
        public string Groupfield { get; set; }
        public string Strcount { get; set; }
        public string Prp { get; set; }
        public string Indicator { get; set; }
        public string Indicatoroperator { get; set; }
        public bool? Hide { get; set; }
        public string Tablebuf { get; set; }
        public string Reporttypeselect { get; set; }
        public bool? Proverka02 { get; set; }
        public decimal? Const { get; set; }
        public string Conformityright { get; set; }

        public virtual DcCrSetT2 Doc { get; set; }
    }
}
