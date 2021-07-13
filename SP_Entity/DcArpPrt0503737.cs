using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class DcArpPrt0503737
    {
        public DcArpPrt0503737()
        {
            FsRepVnk737List = new HashSet<FsRepVnk737List>();
            FsT112Vnk737List = new HashSet<FsT112Vnk737List>();
            FsT11Vnk737List = new HashSet<FsT11Vnk737List>();
            FsT122Vnk737List = new HashSet<FsT122Vnk737List>();
            FsT12Vnk737List = new HashSet<FsT12Vnk737List>();
            FsT132Vnk737List = new HashSet<FsT132Vnk737List>();
            FsT13Vnk737List = new HashSet<FsT13Vnk737List>();
            FsT21Vnk737List = new HashSet<FsT21Vnk737List>();
            FsT22Vnk737List = new HashSet<FsT22Vnk737List>();
            FsT23Vnk737List = new HashSet<FsT23Vnk737List>();
            FsT24Vnk737List = new HashSet<FsT24Vnk737List>();
            FsT25Vnk737List = new HashSet<FsT25Vnk737List>();
            FsT311Vnk737List = new HashSet<FsT311Vnk737List>();
            FsT312Vnk737List = new HashSet<FsT312Vnk737List>();
            FsT321Vnk737List = new HashSet<FsT321Vnk737List>();
            FsT322Vnk737List = new HashSet<FsT322Vnk737List>();
            FsT331Vnk737List = new HashSet<FsT331Vnk737List>();
            FsT332Vnk737List = new HashSet<FsT332Vnk737List>();
        }

        public decimal Docid { get; set; }
        public decimal? Version { get; set; }
        public DateTime? Logid { get; set; }
        public DateTime? PrintDate { get; set; }
        public string Unsealed { get; set; }
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
        public string Typesource { get; set; }
        public string Source { get; set; }
        public string PrCodereportform { get; set; }

        public virtual ICollection<FsRepVnk737List> FsRepVnk737List { get; set; }
        public virtual ICollection<FsT112Vnk737List> FsT112Vnk737List { get; set; }
        public virtual ICollection<FsT11Vnk737List> FsT11Vnk737List { get; set; }
        public virtual ICollection<FsT122Vnk737List> FsT122Vnk737List { get; set; }
        public virtual ICollection<FsT12Vnk737List> FsT12Vnk737List { get; set; }
        public virtual ICollection<FsT132Vnk737List> FsT132Vnk737List { get; set; }
        public virtual ICollection<FsT13Vnk737List> FsT13Vnk737List { get; set; }
        public virtual ICollection<FsT21Vnk737List> FsT21Vnk737List { get; set; }
        public virtual ICollection<FsT22Vnk737List> FsT22Vnk737List { get; set; }
        public virtual ICollection<FsT23Vnk737List> FsT23Vnk737List { get; set; }
        public virtual ICollection<FsT24Vnk737List> FsT24Vnk737List { get; set; }
        public virtual ICollection<FsT25Vnk737List> FsT25Vnk737List { get; set; }
        public virtual ICollection<FsT311Vnk737List> FsT311Vnk737List { get; set; }
        public virtual ICollection<FsT312Vnk737List> FsT312Vnk737List { get; set; }
        public virtual ICollection<FsT321Vnk737List> FsT321Vnk737List { get; set; }
        public virtual ICollection<FsT322Vnk737List> FsT322Vnk737List { get; set; }
        public virtual ICollection<FsT331Vnk737List> FsT331Vnk737List { get; set; }
        public virtual ICollection<FsT332Vnk737List> FsT332Vnk737List { get; set; }
    }
}
