namespace ChartDemo.Models;

public class SeriesConfiguration
{
    public decimal RandomLowerBorder { get; set; }

    public decimal RandomUpperBorder { get; set; }

    public List<decimal> XValues { get; set; } = new();
}