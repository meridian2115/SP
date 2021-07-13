using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class JmsSubscriptions
    {
        public string Clientid { get; set; }
        public string Subname { get; set; }
        public string Topic { get; set; }
        public string Selector { get; set; }
    }
}
