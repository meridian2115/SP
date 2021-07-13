using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class DcArpFoVnk3
    {
        public DcArpFoVnk3()
        {
            FsT1FoVnk3List = new HashSet<FsT1FoVnk3List>();
            FsT2FoVnk3List = new HashSet<FsT2FoVnk3List>();
            FsT3FoVnk3List = new HashSet<FsT3FoVnk3List>();
            FsT4FoVnk3List = new HashSet<FsT4FoVnk3List>();
            FsT5FoVnk3List = new HashSet<FsT5FoVnk3List>();
        }

        public decimal Docid { get; set; }
        public decimal? Version { get; set; }
        public string SePfnLeader { get; set; }
        public string SePfnChiefAcc { get; set; }
        public string SePfnLeaderOfFes { get; set; }
        public string SePfnPostLeader { get; set; }
        public string SePfnPostChiefAcc { get; set; }
        public string SePfnPostLeaderOf { get; set; }
        public string SePfnExecutor { get; set; }
        public string SePfnPostExecutor { get; set; }
        public string SePfnPhone { get; set; }
        public DateTime? Logid { get; set; }
        public string Ord { get; set; }
        public DateTime? PrintDate { get; set; }
        public string Unsealed { get; set; }

        public virtual ICollection<FsT1FoVnk3List> FsT1FoVnk3List { get; set; }
        public virtual ICollection<FsT2FoVnk3List> FsT2FoVnk3List { get; set; }
        public virtual ICollection<FsT3FoVnk3List> FsT3FoVnk3List { get; set; }
        public virtual ICollection<FsT4FoVnk3List> FsT4FoVnk3List { get; set; }
        public virtual ICollection<FsT5FoVnk3List> FsT5FoVnk3List { get; set; }
    }
}
