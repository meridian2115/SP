using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class FsKsFlkCropFiledList
    {
        public decimal Fieldsetid { get; set; }
        public decimal? Tablerownum { get; set; }
        public decimal? FsKsFlkSet1Listid { get; set; }
        public string DictFieldname { get; set; }
        public string DictFieldsysname { get; set; }
        public string CropFiledStart { get; set; }
        public string CropFiledEnd { get; set; }

        public virtual FsKsFlkSet1List FsKsFlkSet1List { get; set; }
    }
}
