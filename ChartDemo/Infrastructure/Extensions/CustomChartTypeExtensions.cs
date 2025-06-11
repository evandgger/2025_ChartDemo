namespace ChartDemo.Infrastructure.Extensions;

public static class CustomChartTypeExtensions
{
    public static int ToInt(this CustomChartType type)
    {
        return (int)type;
    }
}