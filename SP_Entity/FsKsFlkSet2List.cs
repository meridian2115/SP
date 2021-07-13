using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class FsKsFlkSet2List
    {
        public decimal Fieldsetid { get; set; }
        public decimal? Tablerownum { get; set; }
        public decimal? FsKsFlkSet1Listid { get; set; }
        public string FieldName { get; set; }
        public string FieldSysname { get; set; }
        public string TableName { get; set; }
        public string TableColumn { get; set; }
        public string NumberColumn { get; set; }
        public string NameNumbercolumn { get; set; }
        public string CropStart { get; set; }
        public string CropEnd { get; set; }
        public string Fieldname1 { get; set; }
        public string Filtervalue1 { get; set; }
        public string Fieldname2 { get; set; }
        public string Filtervalue2 { get; set; }
        public string Exp1 { get; set; }
        public string Exp2 { get; set; }
        public string Contentrow { get; set; }

        public virtual FsKsFlkSet1List FsKsFlkSet1List { get; set; }
    }
}
