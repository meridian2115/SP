using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class FsPuioVls782List
    {
        public decimal? Docid { get; set; }
        public decimal? Tablerownum { get; set; }
        public decimal Fieldsetid { get; set; }
        public string Identmassive { get; set; }
        public string Budget { get; set; }
        public string Budgetclass { get; set; }
        public string Kindofactivity { get; set; }
        public string Persaccindicator { get; set; }
        public string Ofk { get; set; }
        public string Contour { get; set; }
        public string Persacc { get; set; }
        public string Subordinateorg { get; set; }
        public string Codecs { get; set; }
        public string Budgetcommitment { get; set; }
        public string Orterclass { get; set; }
        public string Closeturnovers { get; set; }
        public string Fedadrinvprogr { get; set; }
        public string Finorgan { get; set; }
        public decimal? Turnoverdt { get; set; }
        public decimal? Turnoverkt { get; set; }
        public decimal? Balansedt { get; set; }
        public decimal? Balansekt { get; set; }

        public virtual DcVlsReport0531782 Doc { get; set; }
    }
}
