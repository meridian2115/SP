using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class UpdAccesslevelMigrLog
    {
        public DateTime? LogTime { get; set; }
        public string TabName { get; set; }
        public string KbkFields { get; set; }
        public string DateField { get; set; }
        public short? IsMigration { get; set; }
        public string Usl { get; set; }
        public string Kbk { get; set; }
        public DateTime? DateKbk { get; set; }
        public DateTime? DateStartKbk { get; set; }
        public DateTime? DateEndKbk { get; set; }
        public string MessageError { get; set; }
    }
}
