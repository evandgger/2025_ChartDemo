using System.Windows.Forms.DataVisualization.Charting;

namespace ChartDemo.SeriesTransformers;

public class ShiftYTransformer : BaseTransformer
{
    public override void TransformPoint(DataPoint point, decimal coefficient)
    {
        var yValue = point.YValues[0];

        var updatedValue = yValue + (double)coefficient;

        point.SetValueY(updatedValue);
    }
}