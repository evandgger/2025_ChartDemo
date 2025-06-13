using System.Windows.Forms.DataVisualization.Charting;
using ChartDemo.Infrastructure.Extensions;
using ChartDemo.Infrastructure.Helpers;

namespace ChartDemo.SeriesTransformers
{
    public class StretchXTransformer: BaseTransformer
    {
        public override void TransformPoint(DataPoint point, decimal coefficient)
        {
            if (coefficient.IsZero())
            {
                MessageBoxHelper.ShowWarning("Unable to stretch. Coefficient is 0");
            }
            else
            {
                point.XValue = coefficient.IsPositive()
                    ? point.XValue / (double)coefficient
                    : point.XValue * Math.Abs((double)coefficient);
            }
        }
    }
}
