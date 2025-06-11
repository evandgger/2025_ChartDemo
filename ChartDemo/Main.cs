using ChartDemo.Constants;
using ChartDemo.Infrastructure.Extensions;
using ChartDemo.Infrastructure.Helpers;
using ChartDemo.Models;

namespace ChartDemo
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void buildButton_Click(object sender, EventArgs e)
        {
            try
            {
                var inputStatuses = new List<bool>();

                inputStatuses.Add(startRangeInput.TryParseDecimalValue(out var startRange, ValidationMessage.StartRangeRequired));
                inputStatuses.Add(endRangeInput.TryParseDecimalValue(out var endRange, ValidationMessage.EndRangeRequired));
                inputStatuses.Add(stepInput.TryParseDecimalValue(out var step, ValidationMessage.StepRequired));

                if (inputStatuses.AreValid())
                {
                    var configuration = new InputConfiguration(startRange, endRange, step);

                    ValidateConfiguration(configuration);

                    rangeLabel.SetRange(true, GenerateRange(configuration));
                }
                else
                {
                    rangeLabel.SetRange(false);
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, ValidationMessage.ErrorCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            //var aText = startRangeInput.Text;
            //var bText = endRangeInput.Text;
            //var hText = stepInput.Text;

            //var isAValid = double.TryParse(aText, out var a);
            //var isBValid = double.TryParse(bText, out var b);
            //var isHValid = double.TryParse(hText, out var h);

            //if (!isAValid || !isBValid || !isHValid)
            //{
            //    rangeLabel.Text = string.Empty;
            //    rangeLabel.Visible = false;

            //    MessageBox.Show("Text", "Error");

            //    return;
            //}

            //if (b <= a)
            //{
            //    var swap = b;
            //    b = a;
            //    a = swap;

            //    startRangeInput.Text = a.ToString();
            //    endRangeInput.Text = b.ToString();
            //}

            //if (h < 0)
            //{
            //    h = Math.Abs(h);

            //    stepInput.Text = h.ToString();

            //    MessageBox.Show("H must positive", "Info");
            //}

            //if (h == 0)
            //{
            //    h = 1;

            //    stepInput.Text = h.ToString();

            //    MessageBox.Show("H != 0", "Info");
            //}

            //var xPoints = new List<double>();

            //for (var step = a; step <= b; step += h)
            //{
            //    xPoints.Add(step);
            //}

            //var series = mainChart.Series;

            //foreach (var seriesItem in series)
            //{
            //    seriesItem.Points.Clear();
            //}

            //var isCustomCheckBoxChecked = customCheckBox.Checked;
            //var isRandomCheckBoxChecked = randomCheckBox.Checked;

            //var random = new Random();

            //if (isCustomCheckBoxChecked || isRandomCheckBoxChecked)
            //{
            //    if (isCustomCheckBoxChecked)
            //    {
            //        var customSeries = mainChart.Series["Custom"];

            //        foreach (var x in xPoints)
            //        {
            //            var y = x;

            //            customSeries.Points.AddXY(x, y);
            //        }
            //    }

            //    if (isRandomCheckBoxChecked)
            //    {
            //        var randomSeries = mainChart.Series["Random"];

            //        foreach (var x in xPoints)
            //        {
            //            var y = random.Next(-10, 11);

            //            randomSeries.Points.AddXY(x, y);
            //        }
            //    }
            //}
            //else
            //{
            //    MessageBox.Show("Please, select the series", "Warning");
            //}
        }

        private string GenerateRange(InputConfiguration configuration)
        {
            return $"Range: [{configuration.StartRange};{configuration.EndRange}]. Step is {configuration.Step}";
        }

        private void ValidateConfiguration(InputConfiguration configuration)
        {
            ValidateRange(configuration);
            ValidateStep(configuration);
            EnsureChartTypeIsSelected();
            EnsureAtLeastOneSeriesChecked();
        }

        private void ValidateRange(InputConfiguration configuration)
        {
            if (configuration.StartRange == configuration.EndRange)
            {
                if (configuration.StartRange.IsZero())
                {
                    startRangeInput.SetDecimalValue(SeriesConstants.DefaultStartRange);
                    endRangeInput.SetDecimalValue(SeriesConstants.DefaultEndRange);

                    MessageBoxHelper.ShowWarning(ValidationMessage.RangeIsZeroForBoth);
                }
                else
                {
                    var newRange = -configuration.EndRange;

                    var inputToUpdate = newRange.IsPositive() ?
                        endRangeInput : startRangeInput;

                    inputToUpdate.SetDecimalValue(newRange);

                    MessageBoxHelper.ShowWarning(ValidationMessage.RangeIsTheSame);
                }
            }

            if (configuration.StartRange > configuration.EndRange)
            {
                (configuration.StartRange, configuration.EndRange) 
                    = (configuration.EndRange, configuration.StartRange);

                startRangeInput.SetDecimalValue(configuration.StartRange);
                endRangeInput.SetDecimalValue(configuration.EndRange);

                MessageBoxHelper.ShowWarning(ValidationMessage.RangeIsReversed);
            }
        }

        private void ValidateStep(InputConfiguration configuration)
        {
            if (configuration.Step.IsZero())
            {
                stepInput.SetDecimalValue(SeriesConstants.DefaultStep);

                MessageBoxHelper.ShowWarning(ValidationMessage.StepIsZero);
            }

            if (configuration.Step.IsNegative())
            {
                stepInput.SetDecimalValue(Math.Abs(configuration.Step));

                MessageBoxHelper.ShowWarning(ValidationMessage.StepIsNegative);
            }
        }

        private void EnsureChartTypeIsSelected()
        {
            var selectedIndex = chartTypeComboBox.SelectedIndex;

            if (selectedIndex == SeriesConstants.UnselectedIndex)
            {
                chartTypeComboBox.SelectedIndex = CustomChartType.Spline.ToInt();
            }
        }

        private void EnsureAtLeastOneSeriesChecked()
        {
            var isSelected = false;

            var controls = seriesGroupBox.Controls;

            foreach (var control in controls)
            {
                if (control is CheckBox checkBox && checkBox.Checked)
                {
                    isSelected = true;

                    break;
                }
            }

            if (!isSelected)
            {
                customCheckBox.Checked = true;
            }
        }

        private void chartTypeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedIndex = (CustomChartType) chartTypeComboBox.SelectedIndex;

            var series = mainChart.Series;

            var type = Configuration.SeriesMapping[selectedIndex];

            foreach (var seriesItem in series)
            {
                seriesItem.ChartType = type;
            }
        }
    }
}
