using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class DcReport0503154
    {
        public DcReport0503154()
        {
            FsC1T10503154List = new HashSet<FsC1T10503154List>();
            FsC2T20503154List = new HashSet<FsC2T20503154List>();
            FsC3Balance154List = new HashSet<FsC3Balance154List>();
            FsC3Balance154OList = new HashSet<FsC3Balance154OList>();
            FsS3S3T1154List = new HashSet<FsS3S3T1154List>();
            FsS3S3T2154List = new HashSet<FsS3S3T2154List>();
            FsS3S3T3154List = new HashSet<FsS3S3T3154List>();
            FsS3S3T4154List = new HashSet<FsS3S3T4154List>();
            FsS3S3T5154List = new HashSet<FsS3S3T5154List>();
            FsS3S3T6154List = new HashSet<FsS3S3T6154List>();
            FsS3S3T7154List = new HashSet<FsS3S3T7154List>();
        }

        public decimal Docid { get; set; }
        public decimal? Version { get; set; }
        public decimal? C3Sumstart { get; set; }
        public decimal? C3Sumend { get; set; }
        public string C3Lncd0300 { get; set; }
        public string C3Lncd0300Old { get; set; }
        public decimal? C3SumendOld { get; set; }
        public decimal? C3SumstartOld { get; set; }
        public string C3CountBal { get; set; }
        public string C3CountBalO { get; set; }
        public string HrPnfLeader { get; set; }
        public string HrPnfChiefAcc { get; set; }
        public string HrPnfLeaderOfFes { get; set; }
        public string HrPnfPostLeader { get; set; }
        public string HrPnfPostChiefAcc { get; set; }
        public string HrPnfPostLeaderOf { get; set; }
        public string HrPnfExecutor { get; set; }
        public string HrPnfPostExecutor { get; set; }
        public string HrPnfPhone { get; set; }
        public string HrOrd { get; set; }
        public string HrNamtip { get; set; }
        public DateTime? Dateminusday { get; set; }
        public DateTime? Year { get; set; }
        public string ExecuterTel { get; set; }
        public decimal? S3Sumstart { get; set; }
        public decimal? S3Sumend { get; set; }
        public string S3Lncd0300 { get; set; }
        public string S3Lncd0120 { get; set; }
        public string S3Glcd0120 { get; set; }
        public decimal? S3Start0120 { get; set; }
        public decimal? S3End0120 { get; set; }
        public string S3Lncd0121 { get; set; }
        public string S3Glcd0121 { get; set; }
        public decimal? S3Start0121 { get; set; }
        public decimal? S3End0121 { get; set; }
        public string S3Lncd0122 { get; set; }
        public string S3Glcd0122 { get; set; }
        public decimal? S3Start0122 { get; set; }
        public decimal? S3End0122 { get; set; }
        public string S3Lncd0130 { get; set; }
        public string S3Glcd0130 { get; set; }
        public decimal? S3Start0130 { get; set; }
        public decimal? S3End0130 { get; set; }
        public string S3Lncd0131 { get; set; }
        public string S3Glcd0131 { get; set; }
        public decimal? S3Start0131 { get; set; }
        public decimal? S3End0131 { get; set; }
        public string S3Lncd0132 { get; set; }
        public string S3Glcd0132 { get; set; }
        public decimal? S3Start0132 { get; set; }
        public decimal? S3End0132 { get; set; }
        public string S3Lncd0141 { get; set; }
        public string S3Glcd0141 { get; set; }
        public decimal? S3Start0141 { get; set; }
        public decimal? S3End0141 { get; set; }

        public virtual ICollection<FsC1T10503154List> FsC1T10503154List { get; set; }
        public virtual ICollection<FsC2T20503154List> FsC2T20503154List { get; set; }
        public virtual ICollection<FsC3Balance154List> FsC3Balance154List { get; set; }
        public virtual ICollection<FsC3Balance154OList> FsC3Balance154OList { get; set; }
        public virtual ICollection<FsS3S3T1154List> FsS3S3T1154List { get; set; }
        public virtual ICollection<FsS3S3T2154List> FsS3S3T2154List { get; set; }
        public virtual ICollection<FsS3S3T3154List> FsS3S3T3154List { get; set; }
        public virtual ICollection<FsS3S3T4154List> FsS3S3T4154List { get; set; }
        public virtual ICollection<FsS3S3T5154List> FsS3S3T5154List { get; set; }
        public virtual ICollection<FsS3S3T6154List> FsS3S3T6154List { get; set; }
        public virtual ICollection<FsS3S3T7154List> FsS3S3T7154List { get; set; }
    }
}
