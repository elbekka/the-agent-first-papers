namespace Calculator.Validation;

public static class NumberValidator
{
    public static bool TryParse(string? input, out double value) => double.TryParse(input, out value);

    public static void EnsureFinite(double value, string paramName)
    {
        if (double.IsNaN(value) || double.IsInfinity(value))
        {
            throw new ArgumentException($"'{paramName}' must be a finite number.", paramName);
        }
    }
}
