using ChartDemo.Models;

namespace ChartDemo.SeriesBuilders;

public class CustomSeriesBuilder : BaseSeriesBuilder
{
    protected override decimal CalculateY(SeriesConfiguration configuration, decimal x)
    {
        var result = Math.Pow((double)x, 3);

        return (decimal) result;
    }
}