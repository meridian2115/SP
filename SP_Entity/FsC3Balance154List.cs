using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class FsC3Balance154List
    {
        public FsC3Balance154List()
        {
            FsInst2List = new HashSet<FsInst2List>();
            FsInst3List = new HashSet<FsInst3List>();
            FsInst4List = new HashSet<FsInst4List>();
            FsInst5List = new HashSet<FsInst5List>();
            FsInst6List = new HashSet<FsInst6List>();
            FsInst7List = new HashSet<FsInst7List>();
            FsInstList = new HashSet<FsInstList>();
        }

        public decimal? Docid { get; set; }
        public decimal? Tablerownum { get; set; }
        public decimal Fieldsetid { get; set; }
        public string S0120Lncd0120 { get; set; }
        public string S0120Glcd0120 { get; set; }
        public decimal? S0120Start0120 { get; set; }
        public decimal? S0120End0120 { get; set; }
        public string S0121Lncd0121 { get; set; }
        public string S0121Glcd0121 { get; set; }
        public decimal? S0121Start0121 { get; set; }
        public decimal? S0121End0121 { get; set; }
        public string S0122Lncd0122 { get; set; }
        public string S0122Glcd0122 { get; set; }
        public decimal? S0122Start0122 { get; set; }
        public decimal? S0122End0122 { get; set; }
        public string S0130Lncd0130 { get; set; }
        public string S0130Glcd0130 { get; set; }
        public decimal? S0130Start0130 { get; set; }
        public decimal? S0130End0130 { get; set; }
        public string S0131Lncd0131 { get; set; }
        public string S0131Glcd0131 { get; set; }
        public decimal? S0131Start0131 { get; set; }
        public decimal? S0131End0131 { get; set; }
        public string S0132Lncd0132 { get; set; }
        public string S0132Glcd0132 { get; set; }
        public decimal? S0132Start0132 { get; set; }
        public decimal? S0132End0132 { get; set; }
        public string S0141Lncd0141 { get; set; }
        public string S0141Glcd0141 { get; set; }
        public decimal? S0141Start0141 { get; set; }
        public decimal? S0141End0141 { get; set; }
        public string ItogoLncd { get; set; }
        public string ItogoGlcd { get; set; }
        public decimal? ItogoItogst { get; set; }
        public decimal? ItogoItogend { get; set; }

        public virtual DcReport0503154 Doc { get; set; }
        public virtual ICollection<FsInst2List> FsInst2List { get; set; }
        public virtual ICollection<FsInst3List> FsInst3List { get; set; }
        public virtual ICollection<FsInst4List> FsInst4List { get; set; }
        public virtual ICollection<FsInst5List> FsInst5List { get; set; }
        public virtual ICollection<FsInst6List> FsInst6List { get; set; }
        public virtual ICollection<FsInst7List> FsInst7List { get; set; }
        public virtual ICollection<FsInstList> FsInstList { get; set; }
    }
}
