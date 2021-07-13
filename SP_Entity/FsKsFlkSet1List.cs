using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class FsKsFlkSet1List
    {
        public FsKsFlkSet1List()
        {
            FsKsFlkCropFiledList = new HashSet<FsKsFlkCropFiledList>();
            FsKsFlkSet2List = new HashSet<FsKsFlkSet2List>();
        }

        public decimal? Docid { get; set; }
        public decimal? Tablerownum { get; set; }
        public decimal Fieldsetid { get; set; }
        public string DictName { get; set; }
        public string DictSysname { get; set; }
        public string DictFieldname { get; set; }
        public string DictFieldsysname { get; set; }
        public string CropStart { get; set; }
        public string CropEnd { get; set; }
        public string Conditiontype { get; set; }
        public string Conditionvalue { get; set; }
        public string Condvalconst { get; set; }
        public string Condtypeconst { get; set; }
        public string Condfieldname { get; set; }
        public string DictFieldnameBuf { get; set; }
        public string DictFieldnamecondBuf { get; set; }
        public string DictTableName { get; set; }
        public string DictTableFieldName { get; set; }
        public string DictTableNameBuf { get; set; }
        public bool? Npa { get; set; }

        public virtual DcCrSetT2 Doc { get; set; }
        public virtual ICollection<FsKsFlkCropFiledList> FsKsFlkCropFiledList { get; set; }
        public virtual ICollection<FsKsFlkSet2List> FsKsFlkSet2List { get; set; }
    }
}
