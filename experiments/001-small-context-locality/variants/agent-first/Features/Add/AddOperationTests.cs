namespace Calculator.Features.Add.Tests;

public sealed class AddOperationTests
{
    [Theory]
    [InlineData(2, 3, 5)]
    [InlineData(-2, 3, 1)]
    [InlineData(0, 0, 0)]
    public void Adds_two_numbers(decimal left, decimal right, decimal expected)
    {
        Assert.Equal(expected, AddOperation.Execute(left, right));
    }
}
