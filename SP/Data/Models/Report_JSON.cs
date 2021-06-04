using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SP.Data.Models
{
    // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse); 
    public class CellDefaultStyleSetting
    {
        [JsonProperty("fontName")]
        public string FontName { get; set; }

        [JsonProperty("fontHeightInPoints")]
        public int FontHeightInPoints { get; set; }

        [JsonProperty("italic")]
        public bool Italic { get; set; }

        [JsonProperty("bold")]
        public bool Bold { get; set; }

        [JsonProperty("underline")]
        public int Underline { get; set; }

        [JsonProperty("strikeout")]
        public bool Strikeout { get; set; }

        [JsonProperty("DEFAULTROWHEIGHTINPOINTS")]
        public int DEFAULTROWHEIGHTINPOINTS { get; set; }

        [JsonProperty("horizontalAlignment")]
        public string HorizontalAlignment { get; set; }

        [JsonProperty("verticalAlignment")]
        public string VerticalAlignment { get; set; }

        [JsonProperty("dataFormat")]
        public string DataFormat { get; set; }

        [JsonProperty("columnWidth")]
        public int ColumnWidth { get; set; }

        [JsonProperty("rowHeight")]
        public int RowHeight { get; set; }

        [JsonProperty("borderTop")]
        public string BorderTop { get; set; }

        [JsonProperty("borderBottom")]
        public string BorderBottom { get; set; }

        [JsonProperty("borderRight")]
        public string BorderRight { get; set; }

        [JsonProperty("borderLeft")]
        public string BorderLeft { get; set; }

        [JsonProperty("wrapText")]
        public bool WrapText { get; set; }

        [JsonProperty("hashCode")]
        public int HashCode { get; set; }

        [JsonProperty("fontColor")]
        public string FontColor { get; set; }

        [JsonProperty("borderTopColor")]
        public string BorderTopColor { get; set; }

        [JsonProperty("borderBottomColor")]
        public string BorderBottomColor { get; set; }

        [JsonProperty("borderRightColor")]
        public string BorderRightColor { get; set; }

        [JsonProperty("borderLeftColor")]
        public string BorderLeftColor { get; set; }

        [JsonProperty("backgroundColor")]
        public string BackgroundColor { get; set; }
    }

    public class ReportParameterValueMap
    {
    }

    public class ReportParameterValueNameMap
    {
    }

    public class InitFilterFunctionMap
    {
    }

    public class ColumnStyleSetting
    {
        [JsonProperty("fontName")]
        public string FontName { get; set; }

        [JsonProperty("fontHeightInPoints")]
        public int FontHeightInPoints { get; set; }

        [JsonProperty("italic")]
        public bool Italic { get; set; }

        [JsonProperty("bold")]
        public bool Bold { get; set; }

        [JsonProperty("underline")]
        public int Underline { get; set; }

        [JsonProperty("strikeout")]
        public bool Strikeout { get; set; }

        [JsonProperty("DEFAULTROWHEIGHTINPOINTS")]
        public int DEFAULTROWHEIGHTINPOINTS { get; set; }

        [JsonProperty("horizontalAlignment")]
        public string HorizontalAlignment { get; set; }

        [JsonProperty("verticalAlignment")]
        public string VerticalAlignment { get; set; }

        [JsonProperty("dataFormat")]
        public string DataFormat { get; set; }

        [JsonProperty("columnWidth")]
        public int ColumnWidth { get; set; }

        [JsonProperty("rowHeight")]
        public int RowHeight { get; set; }

        [JsonProperty("borderTop")]
        public string BorderTop { get; set; }

        [JsonProperty("borderBottom")]
        public string BorderBottom { get; set; }

        [JsonProperty("borderRight")]
        public string BorderRight { get; set; }

        [JsonProperty("borderLeft")]
        public string BorderLeft { get; set; }

        [JsonProperty("wrapText")]
        public bool WrapText { get; set; }

        [JsonProperty("hashCode")]
        public int HashCode { get; set; }

        [JsonProperty("fontColor")]
        public string FontColor { get; set; }

        [JsonProperty("borderTopColor")]
        public string BorderTopColor { get; set; }

        [JsonProperty("borderBottomColor")]
        public string BorderBottomColor { get; set; }

        [JsonProperty("borderRightColor")]
        public string BorderRightColor { get; set; }

        [JsonProperty("borderLeftColor")]
        public string BorderLeftColor { get; set; }

        [JsonProperty("backgroundColor")]
        public string BackgroundColor { get; set; }
    }

    public class LineNameAttributeMap
    {
    }

    public class AttributeList
    {
        [JsonProperty("isHeader")]
        public bool IsHeader { get; set; }

        [JsonProperty("isCrossColumn")]
        public bool IsCrossColumn { get; set; }

        [JsonProperty("atrType")]
        public string AtrType { get; set; }

        [JsonProperty("columnStyleSetting")]
        public ColumnStyleSetting ColumnStyleSetting { get; set; }

        [JsonProperty("isView")]
        public bool IsView { get; set; }

        [JsonProperty("isUserView")]
        public bool IsUserView { get; set; }

        [JsonProperty("isNullCondition")]
        public bool IsNullCondition { get; set; }

        [JsonProperty("isAddQueryColumn")]
        public bool IsAddQueryColumn { get; set; }

        [JsonProperty("isDetailLevel")]
        public bool IsDetailLevel { get; set; }

        [JsonProperty("isHierarchyCalculation")]
        public bool IsHierarchyCalculation { get; set; }

        [JsonProperty("lineNameAttributeMap")]
        public LineNameAttributeMap LineNameAttributeMap { get; set; }

        [JsonProperty("isPercent")]
        public bool IsPercent { get; set; }

        [JsonProperty("isGroupDataAttribute")]
        public bool IsGroupDataAttribute { get; set; }

        [JsonProperty("parentFilterIndexList")]
        public List<object> ParentFilterIndexList { get; set; }

        [JsonProperty("isConditionItem")]
        public bool IsConditionItem { get; set; }

        [JsonProperty("isAccessLevel")]
        public bool IsAccessLevel { get; set; }

        [JsonProperty("atrName")]
        public string AtrName { get; set; }

        [JsonProperty("dictionaryCode")]
        public string DictionaryCode { get; set; }

        [JsonProperty("tableColumn")]
        public string TableColumn { get; set; }

        [JsonProperty("dataType")]
        public string DataType { get; set; }

        [JsonProperty("sortOrder")]
        public int SortOrder { get; set; }

        [JsonProperty("isTotal")]
        public int IsTotal { get; set; }

        [JsonProperty("isLineName")]
        public bool IsLineName { get; set; }

        [JsonProperty("isCalced")]
        public bool IsCalced { get; set; }

        [JsonProperty("expresionCalc")]
        public string ExpresionCalc { get; set; }

        [JsonProperty("refFilterIndex")]
        public int RefFilterIndex { get; set; }

        [JsonProperty("sortType")]
        public string SortType { get; set; }

        [JsonProperty("isDataSetReadOnlyColumn")]
        public bool IsDataSetReadOnlyColumn { get; set; }

        [JsonProperty("isDataSetKeyColumn")]
        public bool IsDataSetKeyColumn { get; set; }

        [JsonProperty("isConcatCodeName")]
        public bool IsConcatCodeName { get; set; }
    }

    public class CellStyleSetting
    {
        [JsonProperty("fontName")]
        public string FontName { get; set; }

        [JsonProperty("fontHeightInPoints")]
        public int FontHeightInPoints { get; set; }

        [JsonProperty("italic")]
        public bool Italic { get; set; }

        [JsonProperty("bold")]
        public bool Bold { get; set; }

        [JsonProperty("underline")]
        public int Underline { get; set; }

        [JsonProperty("strikeout")]
        public bool Strikeout { get; set; }

        [JsonProperty("DEFAULTROWHEIGHTINPOINTS")]
        public int DEFAULTROWHEIGHTINPOINTS { get; set; }

        [JsonProperty("horizontalAlignment")]
        public string HorizontalAlignment { get; set; }

        [JsonProperty("verticalAlignment")]
        public string VerticalAlignment { get; set; }

        [JsonProperty("dataFormat")]
        public string DataFormat { get; set; }

        [JsonProperty("columnWidth")]
        public int ColumnWidth { get; set; }

        [JsonProperty("rowHeight")]
        public int RowHeight { get; set; }

        [JsonProperty("borderTop")]
        public string BorderTop { get; set; }

        [JsonProperty("borderBottom")]
        public string BorderBottom { get; set; }

        [JsonProperty("borderRight")]
        public string BorderRight { get; set; }

        [JsonProperty("borderLeft")]
        public string BorderLeft { get; set; }

        [JsonProperty("wrapText")]
        public bool WrapText { get; set; }

        [JsonProperty("hashCode")]
        public int HashCode { get; set; }

        [JsonProperty("fontColor")]
        public string FontColor { get; set; }

        [JsonProperty("borderTopColor")]
        public string BorderTopColor { get; set; }

        [JsonProperty("borderBottomColor")]
        public string BorderBottomColor { get; set; }

        [JsonProperty("borderRightColor")]
        public string BorderRightColor { get; set; }

        [JsonProperty("borderLeftColor")]
        public string BorderLeftColor { get; set; }

        [JsonProperty("backgroundColor")]
        public string BackgroundColor { get; set; }
    }

    public class TableRow
    {
        [JsonProperty("rowspan")]
        public int Rowspan { get; set; }

        [JsonProperty("colspan")]
        public int Colspan { get; set; }

        [JsonProperty("colLeft")]
        public int ColLeft { get; set; }

        [JsonProperty("rowTop")]
        public int RowTop { get; set; }

        [JsonProperty("colRight")]
        public int ColRight { get; set; }

        [JsonProperty("rowDown")]
        public int RowDown { get; set; }

        [JsonProperty("cellStyleSetting")]
        public CellStyleSetting CellStyleSetting { get; set; }

        [JsonProperty("cellValue")]
        public string CellValue { get; set; }

        [JsonProperty("cellType")]
        public string CellType { get; set; }

        [JsonProperty("cellFormula")]
        public string CellFormula { get; set; }
    }

    public class TableRowsTemplate
    {
        [JsonProperty("rowType")]
        public string RowType { get; set; }

        [JsonProperty("rowTypeNum")]
        public int RowTypeNum { get; set; }

        [JsonProperty("tableRow")]
        public List<TableRow> TableRow { get; set; }

        [JsonProperty("cellArea")]
        public string CellArea { get; set; }

        [JsonProperty("conditionStrTemplate")]
        public string ConditionStrTemplate { get; set; }
    }

    public class FilterFunctionMap
    {
    }

    public class ConditionObj
    {
        [JsonProperty("by_user_str")]
        public string ByUserStr { get; set; }

        [JsonProperty("by_str")]
        public string ByStr { get; set; }

        [JsonProperty("by_sql")]
        public string BySql { get; set; }

        [JsonProperty("dictcode_tab")]
        public List<object> DictcodeTab { get; set; }

        [JsonProperty("cell")]
        public string Cell { get; set; }

        [JsonProperty("isNullCondition")]
        public bool IsNullCondition { get; set; }
    }

    public class LineNameAttributeMap2
    {
    }

    public class ObjAttribute
    {
        [JsonProperty("atr_id")]
        public int AtrId { get; set; }

        [JsonProperty("physobj_id")]
        public int PhysobjId { get; set; }

        [JsonProperty("atr_type")]
        public string AtrType { get; set; }

        [JsonProperty("atr_datatype")]
        public string AtrDatatype { get; set; }

        [JsonProperty("atr_name")]
        public string AtrName { get; set; }

        [JsonProperty("atr_username")]
        public string AtrUsername { get; set; }

        [JsonProperty("atr_hidden")]
        public int AtrHidden { get; set; }

        [JsonProperty("atr_developer_key")]
        public string AtrDeveloperKey { get; set; }

        [JsonProperty("atr_prop1")]
        public string AtrProp1 { get; set; }

        [JsonProperty("atr_prop2")]
        public string AtrProp2 { get; set; }

        [JsonProperty("num_pp")]
        public int NumPp { get; set; }

        [JsonProperty("is_visible")]
        public int IsVisible { get; set; }

        [JsonProperty("is_total")]
        public int IsTotal { get; set; }

        [JsonProperty("is_group")]
        public int IsGroup { get; set; }

        [JsonProperty("is_calced")]
        public int IsCalced { get; set; }

        [JsonProperty("is_line_name")]
        public int IsLineName { get; set; }

        [JsonProperty("expresion_calc")]
        public string ExpresionCalc { get; set; }

        [JsonProperty("cross_table_type")]
        public string CrossTableType { get; set; }

        [JsonProperty("cross_table_num")]
        public int CrossTableNum { get; set; }

        [JsonProperty("condition_obj")]
        public ConditionObj ConditionObj { get; set; }

        [JsonProperty("attribute_function")]
        public string AttributeFunction { get; set; }

        [JsonProperty("is_add_query_column")]
        public bool IsAddQueryColumn { get; set; }

        [JsonProperty("is_hierarchy_calculation")]
        public bool IsHierarchyCalculation { get; set; }

        [JsonProperty("line_name_attribute_map")]
        public LineNameAttributeMap LineNameAttributeMap { get; set; }

        [JsonProperty("isHierarchyUpLevelCode")]
        public bool IsHierarchyUpLevelCode { get; set; }

        [JsonProperty("isPercent")]
        public bool IsPercent { get; set; }

        [JsonProperty("isGroupDataAttribute")]
        public bool IsGroupDataAttribute { get; set; }

        [JsonProperty("sortType")]
        public int SortType { get; set; }
    }

    public class ObjTab
    {
        [JsonProperty("obj_id")]
        public int ObjId { get; set; }

        [JsonProperty("obj_name")]
        public string ObjName { get; set; }

        [JsonProperty("obj_short_name")]
        public string ObjShortName { get; set; }

        [JsonProperty("obj_developer_key")]
        public string ObjDeveloperKey { get; set; }

        [JsonProperty("obj_hidden")]
        public int ObjHidden { get; set; }

        [JsonProperty("obj_attributes")]
        public List<ObjAttribute> ObjAttributes { get; set; }

        [JsonProperty("physobj_id_tab")]
        public List<object> PhysobjIdTab { get; set; }

        [JsonProperty("globalconditon")]
        public List<object> Globalconditon { get; set; }
    }

    public class DocTab
    {
        [JsonProperty("doc_name")]
        public string DocName { get; set; }

        [JsonProperty("obj_tab")]
        public List<ObjTab> ObjTab { get; set; }

        [JsonProperty("doc_conditionsdim_tab")]
        public List<object> DocConditionsdimTab { get; set; }

        [JsonProperty("doc_conditionsdat_tab")]
        public List<object> DocConditionsdatTab { get; set; }
    }

    public class ObjDocTab
    {
        [JsonProperty("doc_tab")]
        public List<DocTab> DocTab { get; set; }
    }

    public class GrObjTab
    {
        [JsonProperty("name_gr")]
        public string NameGr { get; set; }

        [JsonProperty("obj_doc_tab")]
        public List<ObjDocTab> ObjDocTab { get; set; }

        [JsonProperty("type_join")]
        public string TypeJoin { get; set; }

        [JsonProperty("ext_type_join")]
        public string ExtTypeJoin { get; set; }

        [JsonProperty("ext_join_tab")]
        public List<object> ExtJoinTab { get; set; }

        [JsonProperty("join_join_tab")]
        public List<object> JoinJoinTab { get; set; }
    }

    public class TopColumnsTab
    {
        [JsonProperty("atr_type")]
        public string AtrType { get; set; }

        [JsonProperty("atr_datatype")]
        public string AtrDatatype { get; set; }

        [JsonProperty("atr_name")]
        public string AtrName { get; set; }

        [JsonProperty("atr_username")]
        public string AtrUsername { get; set; }

        [JsonProperty("atr_hidden")]
        public int AtrHidden { get; set; }

        [JsonProperty("atr_developer_key")]
        public string AtrDeveloperKey { get; set; }

        [JsonProperty("atr_prop1")]
        public string AtrProp1 { get; set; }

        [JsonProperty("atr_prop2")]
        public string AtrProp2 { get; set; }

        [JsonProperty("num_pp")]
        public int NumPp { get; set; }

        [JsonProperty("is_visible")]
        public int IsVisible { get; set; }

        [JsonProperty("is_total")]
        public int IsTotal { get; set; }

        [JsonProperty("is_group")]
        public int IsGroup { get; set; }

        [JsonProperty("is_calced")]
        public int IsCalced { get; set; }

        [JsonProperty("is_line_name")]
        public int IsLineName { get; set; }

        [JsonProperty("expresion_calc")]
        public string ExpresionCalc { get; set; }

        [JsonProperty("cross_table_type")]
        public string CrossTableType { get; set; }

        [JsonProperty("cross_table_num")]
        public int CrossTableNum { get; set; }

        [JsonProperty("condition_obj")]
        public ConditionObj ConditionObj { get; set; }

        [JsonProperty("attribute_function")]
        public string AttributeFunction { get; set; }

        [JsonProperty("is_add_query_column")]
        public bool IsAddQueryColumn { get; set; }

        [JsonProperty("is_hierarchy_calculation")]
        public bool IsHierarchyCalculation { get; set; }

        [JsonProperty("line_name_attribute_map")]
        public LineNameAttributeMap LineNameAttributeMap { get; set; }

        [JsonProperty("isHierarchyUpLevelCode")]
        public bool IsHierarchyUpLevelCode { get; set; }

        [JsonProperty("isPercent")]
        public bool IsPercent { get; set; }

        [JsonProperty("isGroupDataAttribute")]
        public bool IsGroupDataAttribute { get; set; }

        [JsonProperty("sortType")]
        public int SortType { get; set; }
    }

    public class TableFilterCondition
    {
    }

    public class FilterParameterValueMap
    {
    }

    public class SqlObj
    {
        [JsonProperty("gr_obj_tab")]
        public List<GrObjTab> GrObjTab { get; set; }

        [JsonProperty("top_columns_tab")]
        public List<TopColumnsTab> TopColumnsTab { get; set; }

        [JsonProperty("top_conditionsdim_tab")]
        public List<object> TopConditionsdimTab { get; set; }

        [JsonProperty("top_conditionsdat_tab")]
        public List<object> TopConditionsdatTab { get; set; }

        [JsonProperty("tableFilterCondition")]
        public TableFilterCondition TableFilterCondition { get; set; }

        [JsonProperty("filterParameterValueMap")]
        public FilterParameterValueMap FilterParameterValueMap { get; set; }

        [JsonProperty("isNullCondition")]
        public bool IsNullCondition { get; set; }

        [JsonProperty("isHierarchyDataShow")]
        public bool IsHierarchyDataShow { get; set; }

        [JsonProperty("ds")]
        public int Ds { get; set; }
    }

    public class RoundingObj
    {
        [JsonProperty("type_round")]
        public string TypeRound { get; set; }

        [JsonProperty("number_decimal_digits")]
        public int NumberDecimalDigits { get; set; }
    }

    public class CommonsettingsObj
    {
        [JsonProperty("zero_str")]
        public bool ZeroStr { get; set; }

        [JsonProperty("calc_total")]
        public bool CalcTotal { get; set; }

        [JsonProperty("total_str_up")]
        public bool TotalStrUp { get; set; }

        [JsonProperty("show_only_totals")]
        public bool ShowOnlyTotals { get; set; }

        [JsonProperty("calc_hier")]
        public bool CalcHier { get; set; }

        [JsonProperty("sumdelta_per_period")]
        public bool SumdeltaPerPeriod { get; set; }

        [JsonProperty("delta_per_period")]
        public bool DeltaPerPeriod { get; set; }

        [JsonProperty("col_no_data")]
        public bool ColNoData { get; set; }

        [JsonProperty("calc_logging")]
        public bool CalcLogging { get; set; }

        [JsonProperty("cross_table")]
        public bool CrossTable { get; set; }
    }

    public class AddParamObj
    {
        [JsonProperty("rounding_obj")]
        public RoundingObj RoundingObj { get; set; }

        [JsonProperty("commonsettings_obj")]
        public CommonsettingsObj CommonsettingsObj { get; set; }
    }

    public class Properties
    {
        [JsonProperty("tableName")]
        public string TableName { get; set; }

        [JsonProperty("templateUpSert")]
        public string TemplateUpSert { get; set; }
    }

    public class DataSetDao
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("properties")]
        public Properties Properties { get; set; }
    }

    public class DataSetList
    {
        [JsonProperty("dataSetName")]
        public string DataSetName { get; set; }

        [JsonProperty("filterFunctionMap")]
        public FilterFunctionMap FilterFunctionMap { get; set; }

        [JsonProperty("sqlObj")]
        public SqlObj SqlObj { get; set; }

        [JsonProperty("addParamObj")]
        public AddParamObj AddParamObj { get; set; }

        [JsonProperty("typeDataSet")]
        public string TypeDataSet { get; set; }

        [JsonProperty("progName")]
        public string ProgName { get; set; }

        [JsonProperty("functionParameterDataSetList")]
        public List<object> FunctionParameterDataSetList { get; set; }

        [JsonProperty("isReadOnly")]
        public bool IsReadOnly { get; set; }

        [JsonProperty("dataSetDao")]
        public DataSetDao DataSetDao { get; set; }
    }

    public class TotalAttributeMap
    {
    }

    public class TotalRowList
    {
        [JsonProperty("totalRowName")]
        public string TotalRowName { get; set; }

        [JsonProperty("totalRowLineName")]
        public string TotalRowLineName { get; set; }

        [JsonProperty("totalAttributeMap")]
        public TotalAttributeMap TotalAttributeMap { get; set; }

        [JsonProperty("totalRowCondition")]
        public string TotalRowCondition { get; set; }

        [JsonProperty("isTotal")]
        public bool IsTotal { get; set; }
    }

    public class TableSettingList
    {
        [JsonProperty("isTotalUp")]
        public bool IsTotalUp { get; set; }

        [JsonProperty("tableDataName")]
        public string TableDataName { get; set; }

        [JsonProperty("reportType")]
        public string ReportType { get; set; }

        [JsonProperty("isHierarchyData")]
        public bool IsHierarchyData { get; set; }

        [JsonProperty("isHierarchyDataShow")]
        public bool IsHierarchyDataShow { get; set; }

        [JsonProperty("isNullCondition")]
        public bool IsNullCondition { get; set; }

        [JsonProperty("attributeList")]
        public List<AttributeList> AttributeList { get; set; }

        //[JsonProperty("reportHeaderTemplate")]
        //public List<List<>> ReportHeaderTemplate { get; set; }

        [JsonProperty("cellAreaRHT")]
        public string CellAreaRHT { get; set; }

        //[JsonProperty("tableHeaderTemplate")]
        //public List<List<>> TableHeaderTemplate { get; set; }

        [JsonProperty("cellAreaTHT")]
        public string CellAreaTHT { get; set; }

        [JsonProperty("tableRowsTemplate")]
        public List<TableRowsTemplate> TableRowsTemplate { get; set; }

        [JsonProperty("reportNoteTemplate")]
        public List<object> ReportNoteTemplate { get; set; }

        [JsonProperty("cellAreaRNT")]
        public string CellAreaRNT { get; set; }

        [JsonProperty("cellAreaTemplateTable")]
        public string CellAreaTemplateTable { get; set; }

        [JsonProperty("dataSetList")]
        public List<DataSetList> DataSetList { get; set; }

        [JsonProperty("totalRowList")]
        public List<TotalRowList> TotalRowList { get; set; }

        [JsonProperty("isEditDataSet")]
        public bool IsEditDataSet { get; set; }
    }

    public class FormItemSetting
    {
        [JsonProperty("typeItem")]
        public string TypeItem { get; set; }

        [JsonProperty("selectionType")]
        public string SelectionType { get; set; }

        [JsonProperty("isHierarchyList")]
        public bool IsHierarchyList { get; set; }

        [JsonProperty("isHiddenStartValue")]
        public bool IsHiddenStartValue { get; set; }

        [JsonProperty("isNameOnly")]
        public bool IsNameOnly { get; set; }

        [JsonProperty("isView")]
        public bool IsView { get; set; }
    }

    public class FilterList
    {
        [JsonProperty("isHeader")]
        public bool IsHeader { get; set; }

        [JsonProperty("isCrossColumn")]
        public bool IsCrossColumn { get; set; }

        [JsonProperty("atrType")]
        public string AtrType { get; set; }

        [JsonProperty("columnStyleSetting")]
        public ColumnStyleSetting ColumnStyleSetting { get; set; }

        [JsonProperty("isView")]
        public bool IsView { get; set; }

        [JsonProperty("isUserView")]
        public bool IsUserView { get; set; }

        [JsonProperty("isNullCondition")]
        public bool IsNullCondition { get; set; }

        [JsonProperty("isAddQueryColumn")]
        public bool IsAddQueryColumn { get; set; }

        [JsonProperty("isDetailLevel")]
        public bool IsDetailLevel { get; set; }

        [JsonProperty("isHierarchyCalculation")]
        public bool IsHierarchyCalculation { get; set; }

        [JsonProperty("lineNameAttributeMap")]
        public LineNameAttributeMap LineNameAttributeMap { get; set; }

        [JsonProperty("isPercent")]
        public bool IsPercent { get; set; }

        [JsonProperty("isGroupDataAttribute")]
        public bool IsGroupDataAttribute { get; set; }

        [JsonProperty("parentFilterIndexList")]
        public List<int> ParentFilterIndexList { get; set; }

        [JsonProperty("isConditionItem")]
        public bool IsConditionItem { get; set; }

        [JsonProperty("isAccessLevel")]
        public bool IsAccessLevel { get; set; }

        [JsonProperty("atrName")]
        public string AtrName { get; set; }

        [JsonProperty("dictionaryCode")]
        public string DictionaryCode { get; set; }

        [JsonProperty("tableColumn")]
        public string TableColumn { get; set; }

        [JsonProperty("dataType")]
        public string DataType { get; set; }

        [JsonProperty("formItemSetting")]
        public FormItemSetting FormItemSetting { get; set; }

        [JsonProperty("sortOrder")]
        public int SortOrder { get; set; }

        [JsonProperty("isTotal")]
        public int IsTotal { get; set; }

        [JsonProperty("isLineName")]
        public bool IsLineName { get; set; }

        [JsonProperty("isCalced")]
        public bool IsCalced { get; set; }

        [JsonProperty("expresionCalc")]
        public string ExpresionCalc { get; set; }

        [JsonProperty("sortType")]
        public string SortType { get; set; }

        [JsonProperty("isDataSetReadOnlyColumn")]
        public bool IsDataSetReadOnlyColumn { get; set; }

        [JsonProperty("isDataSetKeyColumn")]
        public bool IsDataSetKeyColumn { get; set; }

        [JsonProperty("isConcatCodeName")]
        public bool IsConcatCodeName { get; set; }
    }

    public class DataRounding
    {
        [JsonProperty("typeRoundingValue")]
        public string TypeRoundingValue { get; set; }

        [JsonProperty("typeRoundingList")]
        public List<object> TypeRoundingList { get; set; }

        [JsonProperty("thousandDataFormat")]
        public string ThousandDataFormat { get; set; }

        [JsonProperty("noroundDataFormat")]
        public string NoroundDataFormat { get; set; }

        [JsonProperty("isBigNumber")]
        public bool IsBigNumber { get; set; }
    }

    public class AdditionalSetting
    {
        [JsonProperty("dataRounding")]
        public DataRounding DataRounding { get; set; }
    }

    public class SheetSettingList
    {
        [JsonProperty("repSheetName")]
        public string RepSheetName { get; set; }

        [JsonProperty("reportParameterValueMap")]
        public ReportParameterValueMap ReportParameterValueMap { get; set; }

        [JsonProperty("reportParameterValueNameMap")]
        public ReportParameterValueNameMap ReportParameterValueNameMap { get; set; }

        [JsonProperty("initFilterFunctionMap")]
        public InitFilterFunctionMap InitFilterFunctionMap { get; set; }

        [JsonProperty("tableSettingList")]
        public List<TableSettingList> TableSettingList { get; set; }

        [JsonProperty("filterList")]
        public List<FilterList> FilterList { get; set; }

        [JsonProperty("additionalSetting")]
        public AdditionalSetting AdditionalSetting { get; set; }

        [JsonProperty("isLinkedFilter")]
        public bool IsLinkedFilter { get; set; }

        [JsonProperty("typeSheet")]
        public string TypeSheet { get; set; }

        [JsonProperty("isDetailLevel")]
        public bool IsDetailLevel { get; set; }

        [JsonProperty("isUserView")]
        public bool IsUserView { get; set; }

        [JsonProperty("isDetailSheet")]
        public bool IsDetailSheet { get; set; }

        [JsonProperty("isSecurity")]
        public bool IsSecurity { get; set; }
    }

    public class Root
    {
        [JsonProperty("cellDefaultStyleSetting")]
        public CellDefaultStyleSetting CellDefaultStyleSetting { get; set; }

        [JsonProperty("sheetSettingList")]
        public List<SheetSettingList> SheetSettingList { get; set; }

        [JsonProperty("setFisrtSheetFilterParams")]
        public bool SetFisrtSheetFilterParams { get; set; }

        [JsonProperty("unifiedVisibleFilterBlock")]
        public bool UnifiedVisibleFilterBlock { get; set; }
    }
}
