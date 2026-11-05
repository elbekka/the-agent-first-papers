namespace Calculator.Domain;

public interface IOperation
{
    OperationType Type { get; }
    double Execute(double left, double right);
}
