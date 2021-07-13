using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class DcArpFahAccpac
    {
        public DcArpFahAccpac()
        {
            FsAgrList = new HashSet<FsAgrList>();
            FsAlsList = new HashSet<FsAlsList>();
            FsBgtList = new HashSet<FsBgtList>();
            FsInstFApList = new HashSet<FsInstFApList>();
            FsRepList = new HashSet<FsRepList>();
            FsTlsList = new HashSet<FsTlsList>();
        }

        public decimal Docid { get; set; }
        public decimal? Version { get; set; }
        public string Name { get; set; }
        public string Login { get; set; }
        public string RtOrfkCode { get; set; }
        public string Description { get; set; }
        public string RtOrfkName { get; set; }
        public string AoPosition { get; set; }
        public string AoFullname { get; set; }
        public string AoTelephone { get; set; }
        public string AoExecuser { get; set; }
        public DateTime? Dataform { get; set; }
        public string Note { get; set; }
        public DateTime? DataStartactive { get; set; }
        public DateTime? DataEndactive { get; set; }

        public virtual ICollection<FsAgrList> FsAgrList { get; set; }
        public virtual ICollection<FsAlsList> FsAlsList { get; set; }
        public virtual ICollection<FsBgtList> FsBgtList { get; set; }
        public virtual ICollection<FsInstFApList> FsInstFApList { get; set; }
        public virtual ICollection<FsRepList> FsRepList { get; set; }
        public virtual ICollection<FsTlsList> FsTlsList { get; set; }
    }
}
