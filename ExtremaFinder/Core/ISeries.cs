using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtremaFinder.Core
{
    interface ISeries
    {
        DevExpress.XtraCharts.Series GetSeries(string function, int low, int high);
    }
}
