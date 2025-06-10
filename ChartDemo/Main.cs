using System.Windows.Forms.DataVisualization.Charting;

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
            var aText = aInput.Text;
            var bText = bInput.Text;
            var hText = hInput.Text;

            var isAValid = double.TryParse(aText, out var a);
            var isBValid = double.TryParse(bText, out var b);
            var isHValid = double.TryParse(hText, out var h);

            if (!isAValid || !isBValid || !isHValid)
            {
                rangeLabel.Text = string.Empty;
                rangeLabel.Visible = false;

                MessageBox.Show("Text", "Error");

                return;
            }

            if (b <= a)
            {
                var swap = b;
                b = a;
                a = swap;

                aInput.Text = a.ToString();
                bInput.Text = b.ToString();
            }

            if (h < 0)
            {
                h = Math.Abs(h);

                hInput.Text = h.ToString();

                MessageBox.Show("H must positive", "Info");
            }

            if (h == 0)
            {
                h = 1;

                hInput.Text = h.ToString();

                MessageBox.Show("H != 0", "Info");
            }

            rangeLabel.Text = $"Range: [{a}, {b}] with step {h}";
            rangeLabel.Visible = true;

            var xPoints = new List<double>();

            for (var step = a; step <= b; step += h)
            {
                xPoints.Add(step);
            }

            var series = mainChart.Series;

            foreach (var seriesItem in series)
            {
                seriesItem.Points.Clear();
            }

            var isCustomCheckBoxChecked = customCheckBox.Checked;
            var isRandomCheckBoxChecked = randomCheckBox.Checked;

            var random = new Random();

            if (isCustomCheckBoxChecked || isRandomCheckBoxChecked)
            {
                if (isCustomCheckBoxChecked)
                {
                    var customSeries = mainChart.Series["Custom"];

                    foreach (var x in xPoints)
                    {
                        var y = x;

                        customSeries.Points.AddXY(x, y);
                    }
                }   

                if (isRandomCheckBoxChecked)
                {
                    var randomSeries = mainChart.Series["Random"];

                    foreach (var x in xPoints)
                    {
                        var y = random.Next(-10, 11);

                        randomSeries.Points.AddXY(x, y);
                    }
                }
            }
            else
            {
                MessageBox.Show("Please, select the series", "Warning");
            }
        }

        private void chartTypeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedIndex = chartTypeComboBox.SelectedIndex;

            var selectedIndexType = (CustomChartType) selectedIndex;

            var series = mainChart.Series;

            foreach (var seriesItem in series)
            {
                switch (selectedIndexType)
                {
                    case CustomChartType.Dot:
                        seriesItem.ChartType = SeriesChartType.Point; 
                        break;
                    case CustomChartType.Column:
                        seriesItem.ChartType = SeriesChartType.Column;
                        break;
                    case CustomChartType.Spline:
                        seriesItem.ChartType = SeriesChartType.Spline;
                        break;
                    case CustomChartType.Line:
                        seriesItem.ChartType = SeriesChartType.Line;
                        break;
                }
            }
        }
    }
}
