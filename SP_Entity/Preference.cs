using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class Preference
    {
        public decimal Id { get; set; }
        public string AppName { get; set; }
        public string UserName { get; set; }
        public string PreferenceMode { get; set; }
        public string ComponentType { get; set; }
        public string ComponentKey { get; set; }
        public string PreferenceName { get; set; }
        public byte[] Value { get; set; }
        public DateTime Created { get; set; }
        public DateTime Modified { get; set; }
    }
}
