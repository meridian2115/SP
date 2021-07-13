using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class TComplex
    {
        public decimal Id { get; set; }
        public string LocalId { get; set; }
        public string GlobalId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal? ParentComplexId { get; set; }
        public decimal? NearComplexId { get; set; }
        public decimal? ActiveComplexAddressId { get; set; }
        public DateTime LastUpdateDate { get; set; }
        public char IsHome { get; set; }
        public string Fingerprint { get; set; }
        public string ComplexType { get; set; }
        public string IsSecret { get; set; }
        public char IsArchive { get; set; }
        public string Username { get; set; }
        public char IsOffline { get; set; }
    }
}
