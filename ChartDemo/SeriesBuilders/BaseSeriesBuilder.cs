using System.Windows.Forms.DataVisualization.Charting;
using ChartDemo.Models;

namespace ChartDemo.SeriesBuilders;

public abstract class BaseSeriesBuilder
{
    protected readonly Random Random = new();

    public void DrawSeries(SeriesConfiguration configuration, Series series)
    {
        foreach (var x in configuration.XValues)
        {
            var y = CalculateY(configuration, x);

            series.Points.AddXY(x, y);
        }
    }

    protected abstract decimal CalculateY(SeriesConfiguration configuration, decimal x);
}