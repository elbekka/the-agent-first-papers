namespace Calculator.Domain;

public sealed class AdditionOperation : IOperation
{
    public OperationType Type => OperationType.Addition;
    public double Execute(double left, double right) => left + right;
}
