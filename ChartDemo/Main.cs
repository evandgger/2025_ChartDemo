using ChartDemo.Constants;
using ChartDemo.Forms;
using ChartDemo.Infrastructure.Extensions;
using ChartDemo.Infrastructure.Helpers;
using ChartDemo.Models;
using OfficeOpenXml;

namespace ChartDemo
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        public decimal? RandomMinimum { get; set; }

        public decimal? RandomMaximum { get; set; }

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
                    var inputConfiguration = new InputConfiguration(startRange, endRange, step);

                    ValidateConfiguration(inputConfiguration);

                    rangeLabel.SetRange(true, GenerateRange(inputConfiguration));

                    var seriesConfiguration = PrepareSeries(inputConfiguration);

                    DrawSeries(seriesConfiguration);
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
        }

        private void DrawSeries(SeriesConfiguration configuration)
        {
            var selectedSeries = GetListOfCheckBoxes(seriesGroupBox);

            foreach (var seriesName in selectedSeries)
            {
                var builder = Configuration.SeriesBuilders[seriesName];

                var series = mainChart.Series[seriesName];

                builder.DrawSeries(configuration, series);
            }
        }

        private SeriesConfiguration PrepareSeries(InputConfiguration configuration)
        {
            ClearSeries();

            var result = new SeriesConfiguration();

            for (var currentStep = configuration.StartRange;
                 currentStep <= configuration.EndRange;
                 currentStep += configuration.Step)
            {
                result.XValues.Add(currentStep);
            }

            result.RandomLowerBorder = RandomMinimum ?? SeriesConstants.DefaultStartRange;
            result.RandomUpperBorder = RandomMaximum ?? SeriesConstants.DefaultEndRange;

            return result;
        }

        private void ClearSeries()
        {
            foreach (var series in mainChart.Series)
            {
                series.Points.Clear();
            }
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
                    configuration.StartRange = SeriesConstants.DefaultStartRange;
                    configuration.EndRange = SeriesConstants.DefaultEndRange;

                    startRangeInput.SetDecimalValue(configuration.StartRange);
                    endRangeInput.SetDecimalValue(configuration.EndRange);

                    MessageBoxHelper.ShowWarning(ValidationMessage.RangeIsZeroForBoth);
                }
                else
                {
                    var newRange = -configuration.EndRange;

                    if (newRange.IsPositive())
                    {
                        configuration.EndRange = newRange;
                        endRangeInput.SetDecimalValue(configuration.EndRange);
                    }
                    else
                    {
                        configuration.StartRange = newRange;
                        startRangeInput.SetDecimalValue(configuration.StartRange);
                    }

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
            var rangeLength = configuration.EndRange - configuration.StartRange;

            if (configuration.Step > rangeLength)
            {
                configuration.Step = SeriesConstants.DefaultStep;

                stepInput.SetDecimalValue(configuration.Step);

                MessageBoxHelper.ShowWarning(ValidationMessage.StepIsGreaterThanRange);
            }

            if (configuration.Step.IsZero())
            {
                configuration.Step = SeriesConstants.DefaultStep;

                stepInput.SetDecimalValue(configuration.Step);

                MessageBoxHelper.ShowWarning(ValidationMessage.StepIsZero);
            }

            if (configuration.Step.IsNegative())
            {
                configuration.Step = Math.Abs(configuration.Step);

                stepInput.SetDecimalValue(configuration.Step);

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

        private List<string> GetListOfCheckBoxes(GroupBox groupBox)
        {
            var result = new List<string>();

            var controls = groupBox.Controls;

            foreach (var control in controls)
            {
                if (control is CheckBox checkBox && checkBox.Checked)
                {
                    result.Add(checkBox.Text);
                }
            }

            return result;
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
            var selectedIndex = (CustomChartType)chartTypeComboBox.SelectedIndex;

            var series = mainChart.Series;

            var type = Configuration.SeriesMapping[selectedIndex];

            foreach (var seriesItem in series)
            {
                seriesItem.ChartType = type;
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var inputStatuses = new List<bool>();

            inputStatuses.Add(startRangeInput.TryParseDecimalValue(out var startRange, ValidationMessage.StartRangeRequired));
            inputStatuses.Add(endRangeInput.TryParseDecimalValue(out var endRange, ValidationMessage.EndRangeRequired));
            inputStatuses.Add(stepInput.TryParseDecimalValue(out var step, ValidationMessage.StepRequired));

            var seriesAreNotEmpty = mainChart.Series.SeriesAreNotEmpty();

            if (inputStatuses.AreValid() && seriesAreNotEmpty)
            {
                try
                {
                    using (var dialog = new SaveFileDialog())
                    {
                        dialog.OverwritePrompt = true;

                        dialog.Title = Configuration.SaveDialogTitle;
                        dialog.Filter = Configuration.FileFilter;

                        if (dialog.ShowDialog() == DialogResult.OK)
                        {
                            var filePath = dialog.FileName;

                            if (File.Exists(filePath))
                            {
                                File.Delete(filePath);
                            }

                            SaveChartToExcel(filePath);
                        }
                    }
                }
                catch (Exception exception)
                {
                    MessageBox.Show(exception.Message);
                }
            }
            else
            {
                MessageBoxHelper.ShowWarning("Chart's configuration is not valid");
            }
        }

        private void SaveChartToExcel(string filePath)
        {
            var fileInfo = new FileInfo(filePath);

            using var excelPackage = new ExcelPackage(fileInfo);

            var detailsWorksheet = excelPackage.Workbook.Worksheets.Add("Details");

            var row = 1;
            var column = 1;

            detailsWorksheet.Cells[row, column++].Value = "Start range";
            detailsWorksheet.Cells[row++, column].Value = startRangeInput.Text;

            column = 1;

            detailsWorksheet.Cells[row, column++].Value = "End range";
            detailsWorksheet.Cells[row++, column].Value = endRangeInput.Text;

            column = 1;

            detailsWorksheet.Cells[row, column++].Value = "Step";
            detailsWorksheet.Cells[row++, column].Value = stepInput.Text;

            if (RandomMinimum.HasValue && RandomMaximum.HasValue)
            {
                column = 1;

                detailsWorksheet.Cells[row, column++].Value = "Random minimum";
                detailsWorksheet.Cells[row++, column].Value = RandomMinimum.Value;

                column = 1;

                detailsWorksheet.Cells[row, column++].Value = "Random minimum";
                detailsWorksheet.Cells[row, column].Value = RandomMaximum.Value;
            }
            
            var checkedSeries = GetListOfCheckBoxes(seriesGroupBox);

            foreach (var seriesName in checkedSeries)
            {
                row = 1;
                column = 1;

                var series = mainChart.Series[seriesName];

                var seriesWorkSheet = excelPackage.Workbook.Worksheets.Add(seriesName);

                seriesWorkSheet.Cells[row, column++].Value = "X Value";
                seriesWorkSheet.Cells[row, column].Value = "Y Value";

                foreach (var point in series.Points)
                {
                    row++;
                    column = 1;

                    seriesWorkSheet.Cells[row, column++].Value = point.XValue;
                    seriesWorkSheet.Cells[row, column].Value = point.YValues.First();
                }
            }

            excelPackage.Save();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (var dialog = new OpenFileDialog())
            {
                dialog.Title = Configuration.OpenDialogTitle;
                dialog.Filter = Configuration.FileFilter;

                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    var filePath = dialog.FileName;

                    randomCheckBox.CheckedChanged -= randomCheckBox_CheckedChanged;

                    DisableAllSeries();

                    OpenExcelFile(filePath);

                    randomCheckBox.CheckedChanged += randomCheckBox_CheckedChanged;
                }
            }
        }

        private void DisableAllSeries()
        {
            var controls = seriesGroupBox.Controls;

            foreach (var control in controls)
            {
                if (control is CheckBox checkBox)
                {
                    checkBox.Checked = false;
                }
            }

            ClearSeries();
        }

        private void OpenExcelFile(string filePath)
        {
            var fileInfo = new FileInfo(filePath);

            using var excelPackage = new ExcelPackage(fileInfo);

            foreach (var worksheet in excelPackage.Workbook.Worksheets)
            {
                if (worksheet.Name == "Details")
                {
                    var startRangeValue = Convert.ToDecimal(worksheet.Cells[1, 2].Value);
                    var endRangeValue = Convert.ToDecimal(worksheet.Cells[2, 2].Value);
                    var stepRangeValue = Convert.ToDecimal(worksheet.Cells[3, 2].Value);

                    startRangeInput.SetDecimalValue(startRangeValue);
                    endRangeInput.SetDecimalValue(endRangeValue);
                    stepInput.SetDecimalValue(stepRangeValue);

                    var randomMinimumText = worksheet.Cells[4, 2].Value;
                    var randomMaximumText = worksheet.Cells[5, 2].Value;

                    if (!string.IsNullOrWhiteSpace(randomMinimumText?.ToString()) &&
                        !string.IsNullOrWhiteSpace(randomMaximumText?.ToString()))
                    {
                        var randomMinimum = Convert.ToDecimal(randomMinimumText);
                        var randomMaximum = Convert.ToDecimal(randomMaximumText);

                        RandomMinimum = randomMinimum;
                        RandomMaximum = randomMaximum;

                        SetRandomRange();
                    }
                }
                else
                {
                    var series = mainChart.Series[worksheet.Name];

                    var controls = seriesGroupBox.Controls;

                    foreach (var control in controls)
                    {
                        if (control is CheckBox checkBox && checkBox.Text == worksheet.Name)
                        {
                            if (checkBox.Text == Configuration.RandomSeries)
                            {
                                if (RandomMaximum.HasValue && RandomMinimum.HasValue)
                                {
                                    checkBox.Checked = true;
                                }
                            }
                            else
                            {
                                checkBox.Checked = true;
                            }
                        }
                    }

                    var startRow = 2;
                    var maxRow = worksheet.Dimension.End.Row;

                    for (var row = startRow; row <= maxRow; row++)
                    {
                        var xValue = worksheet.Cells[row, 1].Value.ToString();
                        var yValue = worksheet.Cells[row, 2].Value.ToString();

                        if (string.IsNullOrWhiteSpace(xValue))
                            break;

                        series.Points.AddXY(
                            Convert.ToDecimal(xValue),
                            Convert.ToDecimal(yValue));
                    }
                }
            }
        }

        private void applyTransformationButton_Click(object sender, EventArgs e)
        {
            var isCoefficientValid = coefficientInput.TryParseDecimalValue(
                out var coefficient,
                ValidationMessage.CoefficientIsRequired);

            var seriesAreNotEmpty = mainChart.Series.SeriesAreNotEmpty();
            var transformers = GetListOfCheckBoxes(transformationGroupBox);

            if (isCoefficientValid && seriesAreNotEmpty && transformers.Any())
            {
                foreach (var transformerName in transformers)
                {
                    var transformer = Configuration.SeriesTransformers[transformerName];

                    transformer.Transform(mainChart.Series, coefficient);
                }

                mainChart.Invalidate();
            }

            else
            {
                MessageBoxHelper.ShowWarning("Chart's configuration is not valid");
            }
        }

        private void instructionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var aboutForm = new AboutForm();

            aboutForm.ShowDialog(this);
        }

        private void randomCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (randomCheckBox.Checked)
            {
                var randomForm = new RandomForm();

                randomForm.FormClosed += (sender, args) =>
                {
                    if (randomForm.RandomMinimum.HasValue && randomForm.RandomMaximum.HasValue)
                    {
                        RandomMinimum = randomForm.RandomMinimum.Value;
                        RandomMaximum = randomForm.RandomMaximum.Value;

                        SetRandomRange();
                    }
                    else
                    {
                        RandomMinimum = null;
                        RandomMaximum = null;

                        randomRangeLabel.Text = string.Empty;
                        randomRangeLabel.Visible = false;

                        randomCheckBox.Checked = false;
                    }
                };

                randomForm.ShowDialog(this);
            }
            else
            {
                RandomMinimum = null;
                RandomMaximum = null;

                randomRangeLabel.Text = string.Empty;
                randomRangeLabel.Visible = false;
            }
        }

        private void SetRandomRange()
        {
            if (RandomMinimum.HasValue && RandomMaximum.HasValue)
            {
                randomRangeLabel.Text = @$"Random range: [{RandomMinimum};{RandomMaximum}]";
                randomRangeLabel.Visible = true;
            }
            else
            {
                randomRangeLabel.Text = string.Empty;
                randomRangeLabel.Visible = false;
            }
        }
    }
}
