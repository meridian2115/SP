using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class DwTabIzmBr17RzprS34
    {
        public Guid Uuid { get; set; }
        public decimal? Year { get; set; }
        public string NumRef { get; set; }
        public string Name { get; set; }
        public string Ist { get; set; }
        public decimal? SumIst1y { get; set; }
        public decimal? SumIst2y { get; set; }
        public decimal? SumIst3y { get; set; }
        public short? IsTotal { get; set; }
        public short? Accesslevel { get; set; }
        public short? IsMigration { get; set; }
    }
}
