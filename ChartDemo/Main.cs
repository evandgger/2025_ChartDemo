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
                MessageBox.Show("Text", "Error");

                return;
            }

            if (b <= a)
            {
                var swap = b;

                b = a;

                a = swap;
            }

            if (h < 0)
            {
                h = Math.Abs(h);

                MessageBox.Show("H must positive", "Info");
            }

            if (h == 0)
            {
                h = 1;

                MessageBox.Show("H != 0", "Info");
            }

            var xPoints = new List<double>();

            for (var step = a;step<= b; step += h)
            {
                xPoints.Add(step);
            }

            var sinSeries = mainChart.Series["sin"];
           
            foreach (var x in xPoints)
            {
                var y = Math.Sin(x);

                sinSeries.Points.AddXY(x, y);
            }
        }
    }
}
