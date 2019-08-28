using System;
using System.Collections.Generic;
using System.Linq;
using DevExpress.XtraCharts;

namespace ExtremaFinder.Core
{
    public class Peaks : IPeaks
    {
        private Dictionary<string, Func<double, double, bool>> comparators = 
            new Dictionary<string, Func<double, double, bool>>()
        {
            {"minimum", (x, y) => x > y},
            {"maximum", (x, y) => x < y}
        };

        public List<ConstantLine> GetPeaks(DevExpress.XtraCharts.Series series, string peaksType)
        {
            var comparator = comparators[peaksType];
            var peaks = new List<ConstantLine>();
            for (int i = 1; i < series.Points.Count - 1; i++)
            {
                if (comparator(series.Points[i - 1].Values.First(), series.Points[i].Values.First()) &&
                    comparator(series.Points[i + 1].Values.First(), series.Points[i].Values.First())
                )
                {
                    peaks.Add(new ConstantLine() { AxisValue = double.Parse(series.Points[i].Argument) });
                }
            }
            return peaks;
        }
    }
}