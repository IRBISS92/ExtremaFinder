using DevExpress.XtraCharts;
using Microsoft.CodeAnalysis.Scripting;
using Microsoft.CodeAnalysis.CSharp.Scripting;


namespace ExtremaFinder.Core
{
    public class Series : ISeries
    {
        public DevExpress.XtraCharts.Series GetSeries(string function, int low, int high)
        {
            var series = new DevExpress.XtraCharts.Series(function, ViewType.Line);
            var expression = CSharpScript.Create<double>(
              code: function,
              globalsType: typeof(ParameterX),
              options: ScriptOptions.Default.WithImports("System.Math")
            );
            var runner = expression.CreateDelegate();
            var globals = new ParameterX();
            for (double i = low; i < high; i += 0.1)
            {
                series.Points.Add(new SeriesPoint(i, runner(new ParameterX() { x = i }).Result));
            }
            ((LineSeriesView)series.View).MarkerVisibility = DevExpress.Utils.DefaultBoolean.False;

            return series;
        }

    }
}