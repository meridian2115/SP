using SP.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SP.Data.Interfaces
{
    interface IRS_repository_ai
    {
        /// <summary>
        /// Получить uuid и наименование отчетов
        /// </summary>
        IEnumerable<RS_repository_ai> Allrepository_ai { get; }
        RS_repository_ai GetReport(string uuid);

    }
}
