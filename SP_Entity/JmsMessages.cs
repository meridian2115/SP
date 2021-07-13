using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class JmsMessages
    {
        public decimal Messageid { get; set; }
        public string Destination { get; set; }
        public decimal? Txid { get; set; }
        public char? Txop { get; set; }
        public byte[] Messageblob { get; set; }
    }
}
