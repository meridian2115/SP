using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class DcRpPrt0503125tofk
    {
        public DcRpPrt0503125tofk()
        {
            FsRepVnk125TofkList = new HashSet<FsRepVnk125TofkList>();
            FsS10S10V125tList = new HashSet<FsS10S10V125tList>();
            FsS11S11V125tList = new HashSet<FsS11S11V125tList>();
            FsS12S12V125tList = new HashSet<FsS12S12V125tList>();
            FsS13S13V125tList = new HashSet<FsS13S13V125tList>();
            FsS14S14V125tList = new HashSet<FsS14S14V125tList>();
            FsS15S15V125tList = new HashSet<FsS15S15V125tList>();
            FsS16S16V125tList = new HashSet<FsS16S16V125tList>();
            FsS17S17V125tList = new HashSet<FsS17S17V125tList>();
            FsS18S18V125tList = new HashSet<FsS18S18V125tList>();
            FsS19S19V125tList = new HashSet<FsS19S19V125tList>();
            FsS1S1V125tList = new HashSet<FsS1S1V125tList>();
            FsS20S20V125tList = new HashSet<FsS20S20V125tList>();
            FsS21S21V125tList = new HashSet<FsS21S21V125tList>();
            FsS22S22V125tList = new HashSet<FsS22S22V125tList>();
            FsS23S23V125tList = new HashSet<FsS23S23V125tList>();
            FsS24tS24V125tList = new HashSet<FsS24tS24V125tList>();
            FsS2S2V125tList = new HashSet<FsS2S2V125tList>();
            FsS3S3V125tList = new HashSet<FsS3S3V125tList>();
            FsS4S4V125tList = new HashSet<FsS4S4V125tList>();
            FsS5S5V125tList = new HashSet<FsS5S5V125tList>();
            FsS6S6V125tList = new HashSet<FsS6S6V125tList>();
            FsS7S7V125tList = new HashSet<FsS7S7V125tList>();
            FsS8S8V125tList = new HashSet<FsS8S8V125tList>();
            FsS9S9V125tList = new HashSet<FsS9S9V125tList>();
        }

        public decimal Docid { get; set; }
        public decimal? Version { get; set; }
        public string Ord { get; set; }
        public string SePfnLeader { get; set; }
        public string SePfnChiefAcc { get; set; }
        public string SePfnLeaderOfFes { get; set; }
        public string SePfnPostLeader { get; set; }
        public string SePfnPostChiefAcc { get; set; }
        public string SePfnPostLeaderOf { get; set; }
        public string SePfnExecutor { get; set; }
        public string SePfnPostExecutor { get; set; }
        public string SePfnPhone { get; set; }
        public DateTime? PrintDate { get; set; }
        public string Unsealed { get; set; }
        public DateTime? Logid { get; set; }
        public string PrCodereportform { get; set; }

        public virtual ICollection<FsRepVnk125TofkList> FsRepVnk125TofkList { get; set; }
        public virtual ICollection<FsS10S10V125tList> FsS10S10V125tList { get; set; }
        public virtual ICollection<FsS11S11V125tList> FsS11S11V125tList { get; set; }
        public virtual ICollection<FsS12S12V125tList> FsS12S12V125tList { get; set; }
        public virtual ICollection<FsS13S13V125tList> FsS13S13V125tList { get; set; }
        public virtual ICollection<FsS14S14V125tList> FsS14S14V125tList { get; set; }
        public virtual ICollection<FsS15S15V125tList> FsS15S15V125tList { get; set; }
        public virtual ICollection<FsS16S16V125tList> FsS16S16V125tList { get; set; }
        public virtual ICollection<FsS17S17V125tList> FsS17S17V125tList { get; set; }
        public virtual ICollection<FsS18S18V125tList> FsS18S18V125tList { get; set; }
        public virtual ICollection<FsS19S19V125tList> FsS19S19V125tList { get; set; }
        public virtual ICollection<FsS1S1V125tList> FsS1S1V125tList { get; set; }
        public virtual ICollection<FsS20S20V125tList> FsS20S20V125tList { get; set; }
        public virtual ICollection<FsS21S21V125tList> FsS21S21V125tList { get; set; }
        public virtual ICollection<FsS22S22V125tList> FsS22S22V125tList { get; set; }
        public virtual ICollection<FsS23S23V125tList> FsS23S23V125tList { get; set; }
        public virtual ICollection<FsS24tS24V125tList> FsS24tS24V125tList { get; set; }
        public virtual ICollection<FsS2S2V125tList> FsS2S2V125tList { get; set; }
        public virtual ICollection<FsS3S3V125tList> FsS3S3V125tList { get; set; }
        public virtual ICollection<FsS4S4V125tList> FsS4S4V125tList { get; set; }
        public virtual ICollection<FsS5S5V125tList> FsS5S5V125tList { get; set; }
        public virtual ICollection<FsS6S6V125tList> FsS6S6V125tList { get; set; }
        public virtual ICollection<FsS7S7V125tList> FsS7S7V125tList { get; set; }
        public virtual ICollection<FsS8S8V125tList> FsS8S8V125tList { get; set; }
        public virtual ICollection<FsS9S9V125tList> FsS9S9V125tList { get; set; }
    }
}
