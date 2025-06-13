using System.Windows.Forms.DataVisualization.Charting;

namespace ChartDemo.SeriesTransformers;

public class ShiftXTransformer : BaseTransformer
{
    public override void TransformPoint(DataPoint point, decimal coefficient)
    {
        point.XValue += (double)coefficient;
    }
}