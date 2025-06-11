using System.Globalization;
using ChartDemo.Infrastructure.Helpers;

namespace ChartDemo.Infrastructure.Extensions;

public static class TextBoxExtensions
{
    public static bool TryParseDecimalValue(this TextBox textBox, out decimal value, string message)
    {
        var text = textBox.Text.Trim();

        var isValid = decimal.TryParse(text, out value);

        if (!isValid)
        {
            MessageBoxHelper.ShowError(message);
        }

        textBox.BackColor = isValid? SystemColors.Window : Color.LightCoral;

        return isValid;
    }

    public static void SetDecimalValue(this TextBox textBox, decimal value)
    {
        textBox.Text = value.ToString(CultureInfo.InvariantCulture);
    }
}