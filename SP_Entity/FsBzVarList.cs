using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class FsBzVarList
    {
        public decimal? Docid { get; set; }
        public decimal? Tablerownum { get; set; }
        public decimal Fieldsetid { get; set; }
        public string Numpp { get; set; }
        public string Vartype { get; set; }
        public string Vardesc { get; set; }
        public string Note { get; set; }
        public string Onelearray { get; set; }
        public string Datatype { get; set; }
        public string Dim { get; set; }
        public string Dimdec { get; set; }
        public string Varinit { get; set; }
        public string InitType { get; set; }

        public virtual DcArpSetBz Doc { get; set; }
    }
}
