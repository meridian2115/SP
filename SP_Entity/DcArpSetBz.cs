using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class DcArpSetBz
    {
        public DcArpSetBz()
        {
            FsBzColumnList = new HashSet<FsBzColumnList>();
            FsBzDescList = new HashSet<FsBzDescList>();
            FsBzPartList = new HashSet<FsBzPartList>();
            FsBzVarList = new HashSet<FsBzVarList>();
            FsDictList = new HashSet<FsDictList>();
            FsSetdateList = new HashSet<FsSetdateList>();
            FsTotalDataList = new HashSet<FsTotalDataList>();
        }

        public decimal Docid { get; set; }
        public decimal? Version { get; set; }
        public string FormOkud { get; set; }
        public string FormRef { get; set; }
        public string AiCode { get; set; }
        public string AiName { get; set; }
        public bool? PeriodDaily { get; set; }
        public bool? PeriodWeekly { get; set; }
        public bool? PeriodTenDaily { get; set; }
        public bool? PeriodMonthly { get; set; }
        public bool? PeriodQuarterly { get; set; }
        public bool? PeriodHalfyearly { get; set; }
        public bool? PeriodYearly { get; set; }
        public bool? PeriodArbitary { get; set; }
        public string GenAuto { get; set; }
        public string PackageName { get; set; }
        public string ProcedureName { get; set; }
        public string NestedProcedureName { get; set; }
        public string VersionF { get; set; }
        public string StatusTable { get; set; }
        public string StatusField { get; set; }
        public string SectionNum { get; set; }
        public string FormName { get; set; }
        public string SectionName { get; set; }
        public string SectionSaveTable { get; set; }
        public string SectionRuTable { get; set; }
        public string SectionType { get; set; }
        public string ZeroRows { get; set; }
        public string CurrencyType { get; set; }
        public string CurrencyCode { get; set; }
        public DateTime? DateStartactive { get; set; }
        public DateTime? DateEndactive { get; set; }
        public string Note { get; set; }
        public string Prefix { get; set; }
        public string Tmp { get; set; }
        public string Test { get; set; }
        public string DlgParamtypeFormula { get; set; }
        public string DlgParamtype { get; set; }
        public string TypeParam { get; set; }
        public string NameParamInfo { get; set; }
        public string ParentParam { get; set; }
        public string NameParam { get; set; }
        public bool? Upperfield { get; set; }
        public string Temp1 { get; set; }
        public string Temp2 { get; set; }
        public string Status1 { get; set; }
        public string Status2 { get; set; }
        public string Status3 { get; set; }
        public string Status4 { get; set; }

        public virtual ICollection<FsBzColumnList> FsBzColumnList { get; set; }
        public virtual ICollection<FsBzDescList> FsBzDescList { get; set; }
        public virtual ICollection<FsBzPartList> FsBzPartList { get; set; }
        public virtual ICollection<FsBzVarList> FsBzVarList { get; set; }
        public virtual ICollection<FsDictList> FsDictList { get; set; }
        public virtual ICollection<FsSetdateList> FsSetdateList { get; set; }
        public virtual ICollection<FsTotalDataList> FsTotalDataList { get; set; }
    }
}
