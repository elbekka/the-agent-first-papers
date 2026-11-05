using Calculator.Domain;

namespace Calculator.Tests;

public sealed class AdditionOperationTests
{
    [Theory]
    [InlineData(2, 3, 5)]
    [InlineData(-2, 3, 1)]
    [InlineData(0, 0, 0)]
    public void Execute_ReturnsSumOfBothOperands(double left, double right, double expected)
    {
        var operation = new AdditionOperation();
        Assert.Equal(expected, operation.Execute(left, right));
    }

    [Fact]
    public void Type_IsAddition()
    {
        Assert.Equal(OperationType.Addition, new AdditionOperation().Type);
    }
}
