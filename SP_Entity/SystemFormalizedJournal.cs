using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class SystemFormalizedJournal
    {
        public decimal? Id { get; set; }
        public DateTime EventTime { get; set; }
        public string SubsystemCode { get; set; }
        public string OperationCode { get; set; }
        public string OperationRes { get; set; }
        public string ObjectType { get; set; }
        public string KeyParam { get; set; }
        public string Param1 { get; set; }
        public string Param2 { get; set; }
        public string Param3 { get; set; }
        public string Param4 { get; set; }
        public string Param5 { get; set; }
        public string Param6 { get; set; }
        public string Param7 { get; set; }
        public string Param8 { get; set; }
        public string Param9 { get; set; }
        public string Param10 { get; set; }
        public string Userid { get; set; }
        public string Message { get; set; }
    }
}
