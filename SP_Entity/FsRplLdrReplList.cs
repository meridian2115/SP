using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class FsRplLdrReplList
    {
        public decimal? Docid { get; set; }
        public decimal? Tablerownum { get; set; }
        public decimal Fieldsetid { get; set; }
        public string P1Role { get; set; }
        public string P1Codeorder { get; set; }
        public string P1Codegroup { get; set; }
        public string P1Grouporder { get; set; }
        public string P1Typeagreement { get; set; }
        public string P1Fio { get; set; }
        public string P1Login { get; set; }
        public string P1Resolution { get; set; }
        public string P1Position { get; set; }
        public string P1Note { get; set; }
        public string P1Department { get; set; }
        public string P2Role { get; set; }
        public string P2Codeorder { get; set; }
        public string P2Codegroup { get; set; }
        public string P2Grouporder { get; set; }
        public string P2Typeagreement { get; set; }
        public string P2Fio { get; set; }
        public string P2Login { get; set; }
        public string P2Resolution { get; set; }
        public string P2Position { get; set; }
        public string P2Note { get; set; }
        public string P2Department { get; set; }
        public string Role { get; set; }
        public string Codeorder { get; set; }
        public string Codegroup { get; set; }
        public string Grouporder { get; set; }
        public string Typeagreement { get; set; }
        public string Fio { get; set; }
        public string Login { get; set; }
        public string Resolution { get; set; }
        public string Position { get; set; }
        public string Note { get; set; }
        public string Department { get; set; }

        public virtual DcMegatableform Doc { get; set; }
    }
}
