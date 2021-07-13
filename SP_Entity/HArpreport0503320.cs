using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class HArpreport0503320
    {
        public HArpreport0503320()
        {
            HfsBaT04005033202019List = new HashSet<HfsBaT04005033202019List>();
            HfsBaT20005033202019List = new HashSet<HfsBaT20005033202019List>();
            HfsBaTab0503320ba2019List = new HashSet<HfsBaTab0503320ba2019List>();
        }

        public decimal Id { get; set; }
        public string Countert0402019 { get; set; }
        public string Countert2002019 { get; set; }

        public virtual ICollection<HfsBaT04005033202019List> HfsBaT04005033202019List { get; set; }
        public virtual ICollection<HfsBaT20005033202019List> HfsBaT20005033202019List { get; set; }
        public virtual ICollection<HfsBaTab0503320ba2019List> HfsBaTab0503320ba2019List { get; set; }
    }
}
