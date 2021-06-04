using SP.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SP.Data.Interfaces
{
    interface IRS_catalog_ai
    {
        IEnumerable<RS_catalog_ai> Allcatalog_ai { get; }
    }
}
