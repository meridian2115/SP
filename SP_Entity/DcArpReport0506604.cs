using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class DcArpReport0506604
    {
        public DcArpReport0506604()
        {
            FsFaip604List = new HashSet<FsFaip604List>();
            FsTabprint604List = new HashSet<FsTabprint604List>();
            FsTotalFaip604List = new HashSet<FsTotalFaip604List>();
            FsTotalGlava604List = new HashSet<FsTotalGlava604List>();
        }

        public decimal Docid { get; set; }
        public decimal? Version { get; set; }
        public string Ord { get; set; }
        public decimal? FaipS07 { get; set; }
        public decimal? FaipS08 { get; set; }
        public decimal? FaipS09 { get; set; }
        public decimal? FaipS10 { get; set; }
        public decimal? FaipS11 { get; set; }
        public string Yearobligations { get; set; }
        public string Nameexecutivebody { get; set; }
        public string Okpoexecutivebody { get; set; }
        public string Namefinancebody { get; set; }
        public string Okpofinancebody { get; set; }
        public string Typeobligation { get; set; }

        public virtual ICollection<FsFaip604List> FsFaip604List { get; set; }
        public virtual ICollection<FsTabprint604List> FsTabprint604List { get; set; }
        public virtual ICollection<FsTotalFaip604List> FsTotalFaip604List { get; set; }
        public virtual ICollection<FsTotalGlava604List> FsTotalGlava604List { get; set; }
    }
}
