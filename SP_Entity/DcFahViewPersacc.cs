using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class DcFahViewPersacc
    {
        public DcFahViewPersacc()
        {
            FsPaData2List = new HashSet<FsPaData2List>();
            FsPaDataList = new HashSet<FsPaDataList>();
        }

        public decimal Docid { get; set; }
        public decimal? Version { get; set; }
        public string Book { get; set; }
        public string Budget { get; set; }
        public string Nmofbdgt { get; set; }
        public string Typebudget { get; set; }
        public string Tofk { get; set; }
        public string Formmode { get; set; }
        public DateTime? Todt { get; set; }
        public DateTime? Dtend { get; set; }
        public string Cdglv { get; set; }
        public string Cdsvr { get; set; }
        public string Nmorg { get; set; }
        public string Perssacc { get; set; }
        public string Tpperssacc { get; set; }
        public bool? Actual { get; set; }
        public string Indc { get; set; }
        public string Cdindc { get; set; }
        public string Planindic { get; set; }
        public string Srcofinf { get; set; }
        public string Oktmo { get; set; }
        public string Typekbk { get; set; }
        public string Kbk { get; set; }
        public string Cdg { get; set; }
        public string Faip { get; set; }
        public string GrGlv { get; set; }
        public string GrTofk { get; set; }
        public string GrLc { get; set; }
        public string GrFaip { get; set; }
        public string GrOktmo { get; set; }
        public string GrSrcofinf { get; set; }
        public string GrTypekbk { get; set; }
        public string GrKbk { get; set; }
        public string GrCdg { get; set; }
        public string GrZero { get; set; }
        public string Login { get; set; }
        public string Xmltest { get; set; }
        public string Stat { get; set; }
        public string Staterror { get; set; }
        public string Xmltest2 { get; set; }
        public string Nmborg { get; set; }
        public string OktmoCopy { get; set; }
        public decimal? Data1Copy { get; set; }
        public decimal? Data2Copy { get; set; }
        public decimal? Data3Copy { get; set; }
        public decimal? Data4Copy { get; set; }
        public decimal? Data5Copy { get; set; }
        public decimal? Data6Copy { get; set; }
        public decimal? Data7Copy { get; set; }
        public decimal? Data8Copy { get; set; }
        public decimal? Data9Copy { get; set; }
        public decimal? Data10Copy { get; set; }
        public decimal? Data11Copy { get; set; }
        public decimal? Data12Copy { get; set; }
        public decimal? Data13Copy { get; set; }
        public decimal? Data14Copy { get; set; }
        public decimal? Data15Copy { get; set; }
        public decimal? Data16Copy { get; set; }
        public decimal? Data17Copy { get; set; }
        public decimal? Data18Copy { get; set; }
        public decimal? Data19Copy { get; set; }
        public decimal? Data20Copy { get; set; }
        public decimal? Data21Copy { get; set; }
        public decimal? Data22Copy { get; set; }
        public decimal? Data23Copy { get; set; }
        public decimal? Data24Copy { get; set; }
        public decimal? Data25Copy { get; set; }
        public decimal? Data26Copy { get; set; }
        public decimal? Data27Copy { get; set; }
        public decimal? Data28Copy { get; set; }
        public decimal? Data29Copy { get; set; }
        public decimal? Data30Copy { get; set; }
        public decimal? Data31Copy { get; set; }
        public decimal? Data32Copy { get; set; }
        public decimal? Data33Copy { get; set; }
        public decimal? Data34Copy { get; set; }
        public decimal? Data35Copy { get; set; }
        public decimal? Data36Copy { get; set; }
        public decimal? Data37Copy { get; set; }
        public decimal? Data38Copy { get; set; }
        public decimal? Data39Copy { get; set; }
        public decimal? Data1CopyCopy { get; set; }
        public decimal? Data2CopyCopy { get; set; }
        public decimal? Data3CopyCopy { get; set; }
        public decimal? Data4CopyCopy { get; set; }
        public decimal? Data5CopyCopy { get; set; }
        public decimal? Data6CopyCopy { get; set; }
        public decimal? Data7CopyCopy { get; set; }
        public decimal? Data8CopyCopy { get; set; }
        public decimal? Data9CopyCopy { get; set; }
        public decimal? Data10CopyCopy { get; set; }
        public decimal? Data11CopyCopy { get; set; }
        public decimal? Data12CopyCopy { get; set; }
        public decimal? Data13CopyCopy { get; set; }
        public decimal? Data14CopyCopy { get; set; }
        public decimal? Data15CopyCopy { get; set; }
        public decimal? Data16CopyCopy { get; set; }
        public decimal? Data17CopyCopy { get; set; }
        public decimal? Data18CopyCopy { get; set; }
        public decimal? Data19CopyCopy { get; set; }
        public decimal? Data20CopyCopy { get; set; }
        public decimal? Data21CopyCopy { get; set; }
        public decimal? Data22CopyCopy { get; set; }
        public decimal? Data23CopyCopy { get; set; }
        public decimal? Data24CopyCopy { get; set; }
        public decimal? Data25CopyCopy { get; set; }
        public decimal? Data26CopyCopy { get; set; }
        public decimal? Data27CopyCopy { get; set; }
        public decimal? Data28CopyCopy { get; set; }
        public decimal? Data29CopyCopy { get; set; }
        public decimal? Data30CopyCopy { get; set; }
        public decimal? Data31CopyCopy { get; set; }
        public decimal? Data32CopyCopy { get; set; }
        public decimal? Data33CopyCopy { get; set; }
        public decimal? Data34CopyCopy { get; set; }
        public decimal? Data35CopyCopy { get; set; }
        public decimal? Data36CopyCopy { get; set; }
        public decimal? Data37CopyCopy { get; set; }
        public decimal? Data38CopyCopy { get; set; }
        public decimal? Data39CopyCopy { get; set; }
        public string VCdglv { get; set; }
        public string VTtest { get; set; }
        public string VNumorg { get; set; }
        public string BccCopy { get; set; }
        public string FundSourceCopy { get; set; }
        public string PppCopy { get; set; }
        public string FaipCopy { get; set; }
        public string PaCopy { get; set; }
        public string C2Copy { get; set; }
        public string C6Copy { get; set; }
        public string Concat { get; set; }
        public string Cdglvmemory { get; set; }
        public string Cdsvrmemory { get; set; }
        public string Cdtofkmemory { get; set; }
        public string Cdbudgetmemory { get; set; }
        public string Cdpamemory { get; set; }
        public string Cdindcmemory { get; set; }
        public string Cdsrcofinfmemory { get; set; }
        public string Cdoktmomemory { get; set; }
        public string Kbkmemory { get; set; }
        public string Cdfaipmemory { get; set; }
        public string FocusField { get; set; }

        public virtual ICollection<FsPaData2List> FsPaData2List { get; set; }
        public virtual ICollection<FsPaDataList> FsPaDataList { get; set; }
    }
}
