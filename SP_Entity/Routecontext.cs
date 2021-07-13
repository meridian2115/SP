using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class Routecontext
    {
        public decimal Routecontextid { get; set; }
        public decimal? Version { get; set; }
        public decimal? Docid { get; set; }
        public decimal Localdocstateid { get; set; }
        public decimal? Ownerid { get; set; }
        public DateTime? Lastprintdate { get; set; }
        public bool? Printed { get; set; }
        public bool? Received { get; set; }
        public decimal? Orgid { get; set; }
        public decimal Archive { get; set; }
        public string Exportstatus { get; set; }
        public decimal Doctypeid { get; set; }
        public decimal Docstateid { get; set; }
        public bool Deleted { get; set; }
        public decimal DocstateVersion { get; set; }
        public decimal? Agentorgid { get; set; }

        public virtual Org Agentorg { get; set; }
    }
}
