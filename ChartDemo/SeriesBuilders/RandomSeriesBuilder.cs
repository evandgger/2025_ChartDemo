using ChartDemo.Models;

namespace ChartDemo.SeriesBuilders;

public class RandomSeriesBuilder : BaseSeriesBuilder
{
    protected override decimal CalculateY(SeriesConfiguration configuration, decimal x)
    {
        var range = configuration.RandomUpperBorder - configuration.RandomLowerBorder;

        var result = configuration.RandomLowerBorder + (decimal)Random.NextDouble() * range;

        return result;
    }
}