using DevExpress.XtraCharts;
using System;
using System.Collections.Generic;

namespace ExtremaFinder.Core
{
    interface IPeaks
    {
        List<ConstantLine> GetPeaks(DevExpress.XtraCharts.Series series, string peaksType);
    }
}
