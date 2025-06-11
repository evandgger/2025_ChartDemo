namespace ChartDemo.Models;

public class InputConfiguration
{
    public InputConfiguration(decimal startRange, decimal endRange, decimal step)
    {
        StartRange = startRange;
        EndRange = endRange;
        Step = step;
    }

    public decimal StartRange { get; set; }

    public decimal EndRange { get; set; }

    public decimal Step { get; set; }
}