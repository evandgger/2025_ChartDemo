using ChartDemo.Constants;
using ChartDemo.Infrastructure.Extensions;
using ChartDemo.Infrastructure.Helpers;

namespace ChartDemo.Forms
{
    public partial class RandomForm : Form
    {
        public decimal? RandomMinimum { get; set; }

        public decimal? RandomMaximum { get; set; }


        public RandomForm()
        {
            InitializeComponent();
        }

        private void setRandomButton_Click(object sender, EventArgs e)
        {
            var inputStatuses = new List<bool>();

            inputStatuses.Add(randomMinimumTextBox.TryParseDecimalValue(out var minimum,  ValidationMessage.RandomMinimumIsRequired));
            inputStatuses.Add(randomMaximumTextBox.TryParseDecimalValue(out var maximum, ValidationMessage.RandomMaximumIsRequired));

            if (inputStatuses.AreValid())
            {
                ValidateRandomRange(ref minimum, ref maximum);

                RandomMinimum = minimum;
                RandomMaximum = maximum;

                Close();
            }
        }

        private void ValidateRandomRange(ref decimal minimum, ref decimal maximum)
        {
            if (minimum > maximum)
            {
                (minimum, maximum) = (maximum, minimum);

                randomMinimumTextBox.SetDecimalValue(minimum);
                randomMaximumTextBox.SetDecimalValue(maximum);

                MessageBoxHelper.ShowWarning(ValidationMessage.RandomRangeIsReversed);
            }
        }
    }
}
