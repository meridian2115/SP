using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class HRefTpinstnkfs
    {
        public HRefTpinstnkfs()
        {
            HfsPrmsblCkfsList = new HashSet<HfsPrmsblCkfsList>();
        }

        public decimal Id { get; set; }
        public string TpInstnCd { get; set; }
        public string TpInstnNm { get; set; }
        public string Note { get; set; }

        public virtual ICollection<HfsPrmsblCkfsList> HfsPrmsblCkfsList { get; set; }
    }
}
