using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class TComplexAddress
    {
        public decimal Id { get; set; }
        public string Digest { get; set; }
        public string Description { get; set; }
        public decimal? ComplexId { get; set; }
        public decimal MaxShipmentSize { get; set; }
        public char CryptRequired { get; set; }
        public string ProtectLevel { get; set; }
        public string CryptoKeyTemplate { get; set; }
        public string CompressContent { get; set; }
        public string Username { get; set; }
        public DateTime? LastUpdateDate { get; set; }
        public string Groups { get; set; }
    }
}
