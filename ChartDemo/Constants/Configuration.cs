using System.Windows.Forms.DataVisualization.Charting;
using ChartDemo.SeriesBuilders;
using ChartDemo.SeriesTransformers;

namespace ChartDemo.Constants;

public static class Configuration
{
    public const string RandomSeries = "Random";

    public const string CustomSeries = "Custom";

    public const string CosSeries = "y = cos (x)";

    public const string OpenDialogTitle = "Select the file";

    public const string SaveDialogTitle = "Save the file";

    public const string FileFilter = "Excel Files|*.xlsx";

    public const string ShiftXTransformer = "shift X";

    public const string ShiftYTransformer = "shift Y";
    
    public const string StretchXTransformer = "stretch X";

    public const string StretchYTransformer = "stretch Y";


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

    public static readonly Dictionary<string, BaseTransformer> SeriesTransformers = new()
    {
        { ShiftXTransformer, new ShiftXTransformer() },
        { ShiftYTransformer, new ShiftYTransformer() },
        { StretchXTransformer, new StretchXTransformer() },
        { StretchYTransformer, new StretchYTransformer() }
    };
}