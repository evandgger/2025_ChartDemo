using System.Windows.Forms.DataVisualization.Charting;

namespace ChartDemo.Constants;

public static class Configuration
{
    public static readonly Dictionary<CustomChartType, SeriesChartType> SeriesMapping = new()
    {
        { CustomChartType.Dot, SeriesChartType.Point },
        { CustomChartType.Column, SeriesChartType.Column },
        { CustomChartType.Spline, SeriesChartType.Spline },
        { CustomChartType.Line, SeriesChartType.Line },
    };
}