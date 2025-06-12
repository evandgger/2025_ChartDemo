using System.Windows.Forms.DataVisualization.Charting;
using ChartDemo.SeriesBuilders;

namespace ChartDemo.Constants;

public static class Configuration
{
    public const string RandomSeries = "Random";

    public const string CustomSeries = "Custom";

    public const string CosSeries = "y = cos (x)";

    public const string OpenDialogTitle = "Select the file";

    public const string SaveDialogTitle = "Save the file";

    public const string FileFilter = "Excel Files|*.xlsx";


    public static readonly Dictionary<CustomChartType, SeriesChartType> SeriesMapping = new()
    {
        { CustomChartType.Dot, SeriesChartType.Point },
        { CustomChartType.Column, SeriesChartType.Column },
        { CustomChartType.Spline, SeriesChartType.Spline },
        { CustomChartType.Line, SeriesChartType.Line }
    };

    public static readonly Dictionary<string, BaseSeriesBuilder> SeriesBuilders = new()
    {
        { RandomSeries, new RandomSeriesBuilder() },
        { CustomSeries, new CustomSeriesBuilder() },
        { CosSeries, new CosSeriesBuilder() }
    };
}