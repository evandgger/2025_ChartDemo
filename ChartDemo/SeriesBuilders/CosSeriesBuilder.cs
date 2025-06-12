using ChartDemo.Models;

namespace ChartDemo.SeriesBuilders;

public class CosSeriesBuilder : BaseSeriesBuilder
{
    protected override decimal CalculateY(SeriesConfiguration configuration, decimal x)
    {
        return (decimal)Math.Cos((double)x);
    }
}