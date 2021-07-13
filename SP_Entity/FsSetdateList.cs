using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class FsSetdateList
    {
        public FsSetdateList()
        {
            FsResamdateList = new HashSet<FsResamdateList>();
        }

        public decimal? Docid { get; set; }
        public decimal? Tablerownum { get; set; }
        public decimal Fieldsetid { get; set; }
        public string Numpp { get; set; }
        public string DataSetCode { get; set; }
        public string CalcType { get; set; }
        public string LedgerSet { get; set; }
        public string LedgerType { get; set; }
        public string SourceCode { get; set; }
        public string SourceAlias { get; set; }
        public string Period { get; set; }
        public string PostingDateFrom { get; set; }
        public string PostingDateTo { get; set; }
        public string VdDateFrom { get; set; }
        public string VdDateTo { get; set; }
        public string InclCorrectPeriod { get; set; }

        public virtual DcArpSetBz Doc { get; set; }
        public virtual ICollection<FsResamdateList> FsResamdateList { get; set; }
    }
}
