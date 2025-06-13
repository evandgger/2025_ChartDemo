namespace ChartDemo.Constants;

public static class ValidationMessage
{
    public const string StartRangeRequired = "Start range is required.";

    public const string EndRangeRequired = "End range is required.";

    public const string StepRequired = "Step is required.";

    public const string StepIsGreaterThanRange = "Step must be less than the range. Default value will be used.";

    public const string RangeIsZeroForBoth = "Start and end of range must be non-zero";

    public const string RangeIsTheSame = "Start and end of range must be different";

    public const string RangeIsReversed = "Start range must be less than end range. Values have been swapped.";

    public const string StepIsZero = "Step must be non-zero. Default value will be used.";

    public const string StepIsNegative = "Step must be positive. Default value will be used.";

    public const string CoefficientIsRequired = "Cofficient is required";

    public const string RandomMinimumIsRequired = "Random minimum is required";

    public const string RandomMaximumIsRequired = "Random maximum is required";

    public const string RandomRangeIsReversed = "Random minimum must be less than random maximum. Values have been swapped.";


    public const string ErrorCaption = "Error";

    public const string WarningCaption = "Warning";

    public const string InfoCaption = "Info";
}