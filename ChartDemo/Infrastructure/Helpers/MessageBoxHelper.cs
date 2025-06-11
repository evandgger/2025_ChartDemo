using ChartDemo.Constants;

namespace ChartDemo.Infrastructure.Helpers;

public static class MessageBoxHelper
{
    public static void ShowWarning(string message)
    {
        MessageBox.Show(message, ValidationMessage.WarningCaption, MessageBoxButtons.OK, MessageBoxIcon.Warning);
    }

    public static void ShowError(string message)
    {
        MessageBox.Show(message, ValidationMessage.ErrorCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
    }

    public static void ShowInfo(string message)
    {
        MessageBox.Show(message, ValidationMessage.InfoCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);
    }
}