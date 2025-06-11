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
}