using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class DcRefSethrmrprts
    {
        public DcRefSethrmrprts()
        {
            FsListList = new HashSet<FsListList>();
        }

        public decimal Docid { get; set; }
        public decimal? Version { get; set; }
        public string Note { get; set; }
        public string RepCdrprtfrm { get; set; }
        public string RepOkudrprtfpr { get; set; }
        public string RepNmrprtfrm { get; set; }
        public string RepFormularrprtfrm { get; set; }
        public string SubjCdsbjctrprt { get; set; }
        public string SubjNmsbjctrprt { get; set; }
        public DateTime? DataStartactive { get; set; }
        public DateTime? DataEndactive { get; set; }
        public string OrgCode { get; set; }
        public string OrgName { get; set; }
        public string OrfkId { get; set; }
        public string SubjNminst { get; set; }
        public string SubjCdinst { get; set; }
        public string CaFullname { get; set; }
        public string CaCdSr { get; set; }
        public string Ksbu { get; set; }

        public virtual ICollection<FsListList> FsListList { get; set; }
    }
}
