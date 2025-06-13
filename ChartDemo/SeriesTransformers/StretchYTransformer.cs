using ChartDemo.Infrastructure.Extensions;
using ChartDemo.Infrastructure.Helpers;
using System.Windows.Forms.DataVisualization.Charting;

namespace ChartDemo.SeriesTransformers
{
    public class StretchYTransformer: BaseTransformer
    {
        public override void TransformPoint(DataPoint point, decimal coefficient)
        {
            var yValue = point.YValues[0];

            if (coefficient.IsZero())
            {
                MessageBoxHelper.ShowWarning("Unable to stretch. Coefficient is 0");
            }
            else
            {
                var updateValue = coefficient.IsPositive() 
                    ? yValue / (double)coefficient 
                    : yValue * Math.Abs((double)coefficient);

                point.SetValueY(updateValue);
            }
        }
    }
}
