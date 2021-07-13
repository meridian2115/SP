using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class DcArpReport0608031
    {
        public DcArpReport0608031()
        {
            FsSection2Tab21List = new HashSet<FsSection2Tab21List>();
            FsSection2Tab22List = new HashSet<FsSection2Tab22List>();
            FsSection2Tab23List = new HashSet<FsSection2Tab23List>();
            FsSection3Tab31List = new HashSet<FsSection3Tab31List>();
            FsSection3Tab32List = new HashSet<FsSection3Tab32List>();
            FsSection3Tab33List = new HashSet<FsSection3Tab33List>();
            FsSection4Tab41List = new HashSet<FsSection4Tab41List>();
            FsSection4Tab42List = new HashSet<FsSection4Tab42List>();
            FsSection4Tab43List = new HashSet<FsSection4Tab43List>();
        }

        public decimal Docid { get; set; }
        public decimal? Version { get; set; }
        public string HrOrgname { get; set; }
        public string HrPostAdress { get; set; }
        public string HrC2 { get; set; }
        public string HrC3 { get; set; }
        public string HrC4 { get; set; }
        public string HrSignpost { get; set; }
        public string HrSignfio { get; set; }
        public string HrSignphone { get; set; }
        public string HrSignemail { get; set; }
        public string HrOrd { get; set; }
        public DateTime? HrDate1 { get; set; }
        public DateTime? HrDate2 { get; set; }
        public DateTime? HrDaterep { get; set; }
        public bool? Section1C1 { get; set; }
        public bool? Section1C2 { get; set; }
        public bool? Section1C3 { get; set; }
        public bool? Section1C4 { get; set; }
        public bool? Section1C5 { get; set; }
        public bool? Section1C6 { get; set; }
        public bool? Section1C7 { get; set; }
        public bool? Section1C8 { get; set; }

        public virtual ICollection<FsSection2Tab21List> FsSection2Tab21List { get; set; }
        public virtual ICollection<FsSection2Tab22List> FsSection2Tab22List { get; set; }
        public virtual ICollection<FsSection2Tab23List> FsSection2Tab23List { get; set; }
        public virtual ICollection<FsSection3Tab31List> FsSection3Tab31List { get; set; }
        public virtual ICollection<FsSection3Tab32List> FsSection3Tab32List { get; set; }
        public virtual ICollection<FsSection3Tab33List> FsSection3Tab33List { get; set; }
        public virtual ICollection<FsSection4Tab41List> FsSection4Tab41List { get; set; }
        public virtual ICollection<FsSection4Tab42List> FsSection4Tab42List { get; set; }
        public virtual ICollection<FsSection4Tab43List> FsSection4Tab43List { get; set; }
    }
}
