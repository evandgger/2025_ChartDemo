using System.Windows.Forms.DataVisualization.Charting;

namespace ChartDemo.Infrastructure.Extensions;

public static class ListExtension
{
    public static bool AreValid(this List<bool> statuses)
    {
        return statuses.All(status => status == true);
    }

    public static bool IsInvalid(this List<bool> statuses)
    {
        return statuses.Any(status => status == false);
    }

    public static bool SeriesAreEmpty(this SeriesCollection seriesCollection)
    {
        var areEmpty = true;

        foreach (var series in seriesCollection)
        {
            if (series.Points.Any())
            {
                areEmpty = false;

                break;
            }
        }

        return areEmpty;
    }

    public static bool SeriesAreNotEmpty(this SeriesCollection seriesCollection)
    {
        var areEmpty = false;

        foreach (var series in seriesCollection)
        {
            if (series.Points.Any())
            {
                areEmpty = true;

                break;
            }
        }

        return areEmpty;
    }
}