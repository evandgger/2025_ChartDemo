namespace ChartDemo.Infrastructure.Extensions;

public static class DecimalExtensions
{
    public static bool IsZero(this decimal value)
    {
        return value == 0;
    }

    public static bool IsPositive(this decimal value)
    {
        return value > 0;
    }

    public static bool IsNegative(this decimal value)
    {
        return value < 0;
    }
}