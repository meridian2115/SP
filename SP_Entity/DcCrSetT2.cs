using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class DcCrSetT2
    {
        public DcCrSetT2()
        {
            FsCheckmultifiltrList = new HashSet<FsCheckmultifiltrList>();
            FsDetalizationList = new HashSet<FsDetalizationList>();
            FsEmptyKsTabEmptyList = new HashSet<FsEmptyKsTabEmptyList>();
            FsForhierarchyList = new HashSet<FsForhierarchyList>();
            FsHrcKbkList = new HashSet<FsHrcKbkList>();
            FsKsFlkSet1List = new HashSet<FsKsFlkSet1List>();
            FsLeftsideparamsList = new HashSet<FsLeftsideparamsList>();
            FsParamtablefiltersList = new HashSet<FsParamtablefiltersList>();
            FsRightsideparamsList = new HashSet<FsRightsideparamsList>();
            FsRowsconformityList = new HashSet<FsRowsconformityList>();
        }

        public decimal Docid { get; set; }
        public decimal? Version { get; set; }
        public string Crcode { get; set; }
        public string Craddcode { get; set; }
        public string PcCodereportform { get; set; }
        public string PcNamereportform { get; set; }
        public string PcSystemnamereportform { get; set; }
        public string PcAiCode { get; set; }
        public string PcAiName { get; set; }
        public string PcAcctgcode { get; set; }
        public string PcAcctgcodeoperator { get; set; }
        public string PcPppcode { get; set; }
        public string PcKvfocode { get; set; }
        public string PcOktmocode { get; set; }
        public string PcPppcodeoperator { get; set; }
        public string PcCdofentoperator { get; set; }
        public string PcCdofent { get; set; }
        public string PcTypesubj { get; set; }
        public string PcNbrstr { get; set; }
        public string PcSt1 { get; set; }
        public string PcSt2 { get; set; }
        public string PcCompare { get; set; }
        public string PcValcom { get; set; }
        public string PcLeftTable { get; set; }
        public string PcNbrstrField { get; set; }
        public string PcExpr { get; set; }
        public bool? PrDaily { get; set; }
        public bool? PrMonthly { get; set; }
        public bool? PrQuarterly { get; set; }
        public bool? PrHalfyearly { get; set; }
        public bool? PrYearly { get; set; }
        public bool? PrOndate { get; set; }
        public DateTime? PrRnddate { get; set; }
        public string PrTemp1 { get; set; }
        public string PrTemp2 { get; set; }
        public string PrTemp3 { get; set; }
        public string PrTemp4 { get; set; }
        public string PrTemp5 { get; set; }
        public string PrTemp6 { get; set; }
        public string PrTempAb1 { get; set; }
        public string PrTempAb2 { get; set; }
        public string PrTempAb3 { get; set; }
        public string PrTempAb4 { get; set; }
        public string PrTempAb5 { get; set; }
        public string PrTempAb6 { get; set; }
        public string PrPeriodicity { get; set; }
        public string PrPeriodicityab { get; set; }
        public bool? PrOnperiod { get; set; }
        public string PrPeriodname { get; set; }
        public bool? PrWeek { get; set; }
        public string PrTemp7 { get; set; }
        public string PrTemp8 { get; set; }
        public string PrTempAb7 { get; set; }
        public string PrTempAb8 { get; set; }
        public bool? PrReorg { get; set; }
        public string Crtype { get; set; }
        public string Crlevel { get; set; }
        public string Exprleft { get; set; }
        public string Exprright { get; set; }
        public string Exprrelation { get; set; }
        public string Expression { get; set; }
        public string Leftparamcount { get; set; }
        public string Rightparamcount { get; set; }
        public string Errortext { get; set; }
        public decimal? CounterTemp { get; set; }
        public bool? ExpressionCheck { get; set; }
        public string DlgParamtypeFormula { get; set; }
        public string DlgParamtype { get; set; }
        public bool? LeftRoundingCheck { get; set; }
        public bool? RightRoundingCheck { get; set; }
        public string LeftRoundingSide { get; set; }
        public string RightRoundingSide { get; set; }
        public string LeftRoundingAcc { get; set; }
        public string RightRoundingAcc { get; set; }
        public string FlkType { get; set; }
        public bool? FlkActual { get; set; }
        public bool? FlkDeleteerror { get; set; }
        public string FlkSection { get; set; }
        public string FlkCheckrow { get; set; }
        public string FlkCommenterr { get; set; }
        public string FlkCheckcolumn { get; set; }
        public bool? FlkCheckattach { get; set; }
        public string FlkLeftparamcount { get; set; }
        public string FlkRightparamcount { get; set; }
        public string FlkCheckcs { get; set; }
        public bool? FlkCheckpair { get; set; }
        public string FlkTablenameregexp { get; set; }
        public string Instcode { get; set; }
        public string Instname { get; set; }
        public string Orgsysname { get; set; }
        public string Reporttype { get; set; }
        public string HrcType { get; set; }
        public string HrcTabl { get; set; }
        public string HrcSum { get; set; }
        public string HrcItog { get; set; }
        public bool? HrcHierarchy { get; set; }
        public bool? HrcNpa { get; set; }
        public bool? Ksi { get; set; }
        public string StrCount { get; set; }
        public bool? Absleft { get; set; }
        public bool? Absright { get; set; }
        public string Namebudget { get; set; }
        public string Codebudg { get; set; }
        public DateTime? DataStartactive { get; set; }
        public DateTime? DataEndactive { get; set; }
        public bool? Periodlr { get; set; }
        public bool? Oktmolr { get; set; }
        public bool? Budgtypelr { get; set; }
        public bool? Typesubjlr { get; set; }
        public bool? Codechjlr { get; set; }
        public string Indicator { get; set; }
        public string Indicatoroperator { get; set; }
        public bool? Indicatorlr { get; set; }
        public bool? Conditioncheck { get; set; }
        public string Linkedcontrol { get; set; }
        public bool? Dependentcheck { get; set; }
        public string Errorks { get; set; }
        public bool? MdkOktmo { get; set; }
        public string Checktype { get; set; }
        public string Checktype2 { get; set; }
        public string Errortype { get; set; }
        public string StateOp { get; set; }
        public string States { get; set; }
        public string StatesRus { get; set; }
        public bool? GrLCodereportform { get; set; }
        public bool? GrLSection { get; set; }
        public bool? GrLColmn { get; set; }
        public bool? GrLLinenumber { get; set; }
        public bool? GrLContentrow { get; set; }
        public bool? GrRCodereportform { get; set; }
        public bool? GrRSection { get; set; }
        public bool? GrRColmn { get; set; }
        public bool? GrRLinenumber { get; set; }
        public bool? GrRContentrow { get; set; }
        public string FlkDatapo { get; set; }
        public string FlkDatas { get; set; }
        public string Reporttypeselect { get; set; }
        public string Errorname { get; set; }
        public bool? Vdk { get; set; }
        public string GroupTypeksCd { get; set; }
        public string GroupTypeksNm { get; set; }
        public string GroupRazdelCd { get; set; }
        public string GroupRazdelNm { get; set; }
        public string HrcGroupfield { get; set; }
        public string FlkDatadoc { get; set; }
        public string HrcColmn { get; set; }

        public virtual ICollection<FsCheckmultifiltrList> FsCheckmultifiltrList { get; set; }
        public virtual ICollection<FsDetalizationList> FsDetalizationList { get; set; }
        public virtual ICollection<FsEmptyKsTabEmptyList> FsEmptyKsTabEmptyList { get; set; }
        public virtual ICollection<FsForhierarchyList> FsForhierarchyList { get; set; }
        public virtual ICollection<FsHrcKbkList> FsHrcKbkList { get; set; }
        public virtual ICollection<FsKsFlkSet1List> FsKsFlkSet1List { get; set; }
        public virtual ICollection<FsLeftsideparamsList> FsLeftsideparamsList { get; set; }
        public virtual ICollection<FsParamtablefiltersList> FsParamtablefiltersList { get; set; }
        public virtual ICollection<FsRightsideparamsList> FsRightsideparamsList { get; set; }
        public virtual ICollection<FsRowsconformityList> FsRowsconformityList { get; set; }
    }
}
