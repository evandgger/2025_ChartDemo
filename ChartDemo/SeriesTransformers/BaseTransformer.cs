using System.Windows.Forms.DataVisualization.Charting;

namespace ChartDemo.SeriesTransformers;

public abstract class BaseTransformer
{
    public void Transform(SeriesCollection seriesCollection, decimal coefficient)
    {
        foreach (var series in seriesCollection)
        {
            foreach (var point in series.Points)
            {
                TransformPoint(point, coefficient);
            }
        }
    }

    public abstract void TransformPoint(DataPoint point, decimal coefficient);
}