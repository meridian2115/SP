using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class FsUbpfkaccountsList
    {
        public decimal Fieldsetid { get; set; }
        public decimal? Tablerownum { get; set; }
        public decimal? Docid { get; set; }
        public string Tofkname { get; set; }
        public string Accounttypename { get; set; }
        public string Accountnum { get; set; }
        public DateTime? Opendate { get; set; }
        public DateTime? Closedate { get; set; }
        public string Accountstatus { get; set; }
        public string Serviceorfkname { get; set; }
        public string RubpcodeAcc { get; set; }
        public string PubpcodeAcc { get; set; }
        public string NubpcodeAcc { get; set; }
        public string Accountorgcode { get; set; }
        public string Accountorgfullname { get; set; }
        public string Ppocode { get; set; }
        public string Pponame { get; set; }
        public string Tofkcode { get; set; }
        public string Tofkorgcode { get; set; }
        public string Accounttypecode { get; set; }
        public string Serviceorfkcode { get; set; }
        public string BudgcodeAcc { get; set; }
        public string GlavacodeAcc { get; set; }

        public virtual DcRefUbpandnubp Doc { get; set; }
    }
}
