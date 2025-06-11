namespace ChartDemo.Infrastructure.Extensions;

public static class LabelExtensions
{
    public static void SetRange(this Label label, bool isSuccessful, string? text = null)
    {
        if (isSuccessful && !string.IsNullOrWhiteSpace(text))
        {
            label.Text = text!;
            label.Visible = true;
        }
        else
        {
            label.Text = string.Empty;
            label.Visible = false;
        }
    }
}