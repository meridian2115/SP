using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class HArpSetBz
    {
        public HArpSetBz()
        {
            HfsBzPartList = new HashSet<HfsBzPartList>();
        }

        public decimal Id { get; set; }
        public string FormRef { get; set; }

        public virtual ICollection<HfsBzPartList> HfsBzPartList { get; set; }
    }
}
